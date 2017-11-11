using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class FormLop : Form
    {
        public class ObjectUndo
        {
            int type;
            String lenh;

            public ObjectUndo(int type, String lenh)
            {
                this.type = type;
                this.lenh = lenh;
            }

            public int getType()
            {
                return type;
            }
            public String getLenh()
            {
                return lenh;
            }
        }

        public Stack st = new Stack();

        int choose = 0;
        const int THEM = 0;
        const int HIEU_CHINH = 1;
        const int XOA = 2;

        int vitri = 0;
        string maKhoa = "";

        public FormLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;

            //this.lOPTableAdapter.Fill(this.dS.LOP);
            maKhoa = ((DataRowView)bdsDsLop[0])["MAKH"].ToString();
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
            else
                cmbKhoa.Enabled = false;

            updateUIButtonPhucHoi();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue == null) return;

            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dS.LOP);
                maKhoa = ((DataRowView)bdsDsLop[0])["MAKH"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDsLop.Position;
            groupBox1.Enabled = true;
            bdsDsLop.AddNew();
            txtMaKhoa.Text = maKhoa;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            gcLop.Enabled = false;
            choose = THEM;

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (choose)
            {
                case THEM:
                    if (txtMaLop.Text.Trim() == "")
                    {
                        MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                        return;
                    }

                    if (txtTenLop.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                        txtTenLop.Focus();
                        return;
                    }

                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.sp_TIMLOP";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@X", SqlDbType.Text).Value = txtMaLop.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret == "1")
                    {
                        MessageBox.Show("Mã lớp bị trùng!", "", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Co the them duoc", "", MessageBoxButtons.OK);
                    }

                    try
                    {
                        bdsDsLop.EndEdit();
                        bdsDsLop.ResetCurrentItem();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.dS.LOP);

                        string lenh = "exec sp_UndoThemLop '" + txtMaLop.Text + "'";
                        ObjectUndo obj = new ObjectUndo(THEM, lenh);
                        st.Push(obj);
                        updateUIButtonPhucHoi();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcLop.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;
                    break;

                case HIEU_CHINH:
                    if (txtTenLop.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                        txtTenLop.Focus();
                        return;
                    }

                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenhKiemTraTenLop = "dbo.sp_KiemTraTenLop ";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenhKiemTraTenLop;
                    Program.sqlcmd.Parameters.Add("@TENLOP", SqlDbType.Text).Value = convertStringToUTF8(txtTenLop.Text.Trim());
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String RetKiemTraTenLop = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (RetKiemTraTenLop == "1")
                    {
                        MessageBox.Show("Tên lớp bị trùng!", "", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Có thể update được", "", MessageBoxButtons.OK);
                    }

                    try
                    {
                        bdsDsLop.EndEdit();
                        bdsDsLop.ResetCurrentItem();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.dS.LOP);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcLop.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;

                    break;
            }


        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDsLop.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtMaLop.Enabled = txtMaKhoa.Enabled = false;
            gcLop.Enabled = false;
            choose = HIEU_CHINH;
        }

        private String convertStringToUTF8(String s)
        {
            var dbEnc = Encoding.UTF8;
            var uniEnc = Encoding.Unicode;
            byte[] dbByte = dbEnc.GetBytes(s);
            byte[] uniBytes = Encoding.Convert(dbEnc, uniEnc, dbByte);
            
            return uniEnc.GetString(uniBytes);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenhKiemTraTenLop = "dbo.sp_KiemTraLopTonTaiSinhVien ";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenhKiemTraTenLop;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.Text).Value = convertStringToUTF8(txtMaLop.Text.Trim());
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String RetKiemTraTenLop = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (RetKiemTraTenLop == "1")
            {
                MessageBox.Show("Không thể xóa lớp này vì có sinh viên trong lớp", "",
                       MessageBoxButtons.OK);
                return;
            }
           
            String maLop = "";
          
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = ((DataRowView)bdsDsLop[bdsDsLop.Position])["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsDsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    bdsDsLop.Position = bdsDsLop.Find("MALOP", maLop);
                    return;
                }
            }

            if (bdsDsLop.Count == 0) btnXoa.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.dS.LOP);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            //{
            //    bdsDsLop.CancelEdit();
            //    if (btnThem.Enabled == false) bdsDsLop.Position = vitri;
            //    gcLop.Enabled = true;
            //    groupBox1.Enabled = false;
            //    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            //    btnGhi.Enabled = btnPhucHoi.Enabled = false;
            //}
            //else
            //{
                if (st.Count == 0)
                    return;

                ObjectUndo ob = (ObjectUndo)st.Pop();
                if (ob.getType() == THEM)
                {
                    MessageBox.Show("Khôi phục sau khi thêm " + ob.getLenh());
                    Program.ExecSqlDataReader(ob.getLenh());
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    if (st.Count == 0)
                    {
                        btnPhucHoi.Enabled = false;
                        //MessageBox.Show("Không có gì để Phục hồi", "THÔNG BÁO", MessageBoxButtons.OK);
                        return;
                    }
                }

            //}
        }

        private void updateUIButtonPhucHoi()
        {
            if (st.Count == 0)
                btnPhucHoi.Enabled = false;
            else
                btnPhucHoi.Enabled = true;
        }

    }
}
