using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class FormLop : Form
    {

        public Stack st = new Stack();

        int choose = 0;

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
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;

            maKhoa = ((DataRowView)bdsDsLop[0])["MAKH"].ToString();
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
            else
                cmbKhoa.Enabled = false;

            groupBox1.Enabled = false;
            btnGhi.Enabled = false;
            updateUIButtonPhucHoi();
        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
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

                maKhoa = layMaKhoaTheoTenKhoa(cmbKhoa.Text.ToString()) ;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDsLop.Position;
            groupBox1.Enabled = true;
            bdsDsLop.AddNew();
            txtMaKhoa.Text = maKhoa;
            txtMaKhoa.Enabled = false;
            txtMaLop.Enabled = txtTenLop.Enabled = true;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            gcLop.Enabled = false;
            choose = Program.THEM;
            btnPhucHoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (choose)
            {
                case Program.THEM:
                    if (!checkInfoAvailable())
                        return;

                    if (!kiemTraMaLop(txtMaLop.Text))
                    {
                        MessageBox.Show("Mã lớp bị trùng!", "", MessageBoxButtons.OK);
                        txtMaLop.Focus();
                        Program.conn.Close();
                        return;
                    }

                    if (!kiemTraTenLop(txtTenLop.Text))
                    {
                        MessageBox.Show("Tên lớp bị trùng !");
                        txtTenLop.Focus();
                        return;
                    }

                    try
                    {
                        bdsDsLop.EndEdit();
                        bdsDsLop.ResetCurrentItem();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.dS.LOP);
                        MessageBox.Show("Thêm lớp thành công", "", MessageBoxButtons.OK);

                        String lenh = "exec sp_UndoThemLop '" + txtMaLop.Text + "'";
                        Program.ObjectUndo obj = new Program.ObjectUndo(Program.THEM, lenh);
                        st.Push(obj);
                        updateUIButtonPhucHoi();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcLop.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;
                    break;

                case Program.HIEU_CHINH:
                    String tenLop = ((DataRowView)bdsDsLop[vitri])["TENLOP"].ToString().Trim();
                    if (txtTenLop.Text.Trim().Equals(tenLop))
                    {
                        if (MessageBox.Show("Bạn đã không thay đổi gì, bạn có muốn thoát chỉnh sửa ?", "Xác nhận",
                              MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            gcLop.Enabled = true;
                            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                            btnGhi.Enabled = false;

                            groupBox1.Enabled = false;
                        }

                        return;
                    }

                    if (!checkInfoAvailable())
                        return;

                    try
                    {
                        bdsDsLop.EndEdit();
                        bdsDsLop.ResetCurrentItem();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.dS.LOP);

                        MessageBox.Show("Hiệu chỉnh thành công", "", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
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
            txtTenLop.Focus();
            gcLop.Enabled = false;
            choose = Program.HIEU_CHINH;

            // lưu stack cho undo
            Lop lop = new Lop(txtMaLop.Text, txtTenLop.Text, txtMaKhoa.Text);
            Program.ObjectUndo obj = new Program.ObjectUndo(Program.HIEU_CHINH, lop);
            st.Push(obj);

            updateUIButtonPhucHoi();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenhKiemTraTenLop = "dbo.sp_KiemTraLopTonTaiSinhVien ";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenhKiemTraTenLop;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.Text).Value = txtMaLop.Text.Trim();
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

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DataRowView dataRow = (DataRowView)bdsDsLop[bdsDsLop.Position];
                    maLop = dataRow["MALOP"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    String tenLop = dataRow["TENLOP"].ToString();
                    String maKhoa = dataRow["MAKH"].ToString();
                    Lop lopRemove = new Lop(maLop, tenLop, maKhoa);
                    Program.ObjectUndo obj = new Program.ObjectUndo(Program.XOA, lopRemove);

                    bdsDsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);

                    st.Push(obj);
                    updateUIButtonPhucHoi();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
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
            reload();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            {
                bdsDsLop.CancelEdit();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

                if (btnThem.Enabled == false) bdsDsLop.Position = vitri;
                gcLop.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

                reload();
            }
            else
            {

                if (st.Count == 0)
                    return;

                Program.ObjectUndo objUndo = (Program.ObjectUndo)st.Peek();
                Object obj = objUndo.obj;

                switch (objUndo.type)
                {
                    case Program.THEM:
                        if (MessageBox.Show("Khôi phục sau khi thêm", "Xác nhận", MessageBoxButtons.OKCancel)
                                        == DialogResult.Cancel)
                            return;

                        st.Pop();
                        String lenh = "";

                        try
                        {
                            lenh = obj.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        Program.ExecSqlDataReader(lenh);
                        this.lOPTableAdapter.Fill(this.dS.LOP);
                        updateUIButtonPhucHoi();

                        break;

                    case Program.HIEU_CHINH:
                        if (MessageBox.Show("Khôi phục sau khi hiệu chỉnh", "Xác nhận", MessageBoxButtons.OKCancel)
                                       == DialogResult.Cancel)
                            return;

                        st.Pop();
                        try
                        {
                            Lop lopHieuChinh = (Lop)objUndo.obj;
                            MessageBox.Show(lopHieuChinh.tenLop);

                            if (Program.conn.State == ConnectionState.Closed)
                                Program.conn.Open();
                            String strLenh = "dbo.sp_UndoHieuChinh";
                            Program.sqlcmd = Program.conn.CreateCommand();
                            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.sqlcmd.CommandText = strLenh;
                            Program.sqlcmd.Parameters.Add("@maLop", SqlDbType.Text).Value = lopHieuChinh.maLop;
                            Program.sqlcmd.Parameters.Add("@tenLop", SqlDbType.Text).Value = lopHieuChinh.tenLop;

                            Program.sqlcmd.ExecuteNonQuery();
                            Program.conn.Close();

                            reload();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        break;

                    case Program.XOA:
                        if (MessageBox.Show("Khôi phục sau khi xóa", "Xác nhận", MessageBoxButtons.OKCancel)
                                       == DialogResult.Cancel)
                            return;

                        st.Pop();

                        try
                        {
                            Lop lopXoa = (Lop)objUndo.obj;

                            String sql = "exec sp_InsertLop N'" + lopXoa.maLop + "', N'" + lopXoa.tenLop + "', N'" + maKhoa + "'";
                            DataTable tb = Program.ExecSqlDataTable(sql);
                            if (tb.Rows.Count > 0)
                                MessageBox.Show("Undo success");
                            else
                                MessageBox.Show("Undo failed");

                            //if (Program.conn.State == ConnectionState.Closed)
                            //    Program.conn.Open();
                            //String strLenh = "dbo.sp_InsertLop";
                            //Program.sqlcmd = Program.conn.CreateCommand();
                            //Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            //Program.sqlcmd.CommandText = strLenh;
                            //Program.sqlcmd.Parameters.Add("@maLop", SqlDbType.Text).Value = lopXoa.maLop;
                            //Program.sqlcmd.Parameters.Add("@tenLop", SqlDbType.Text).Value = lopXoa.tenLop;
                            //Program.sqlcmd.Parameters.Add("@maKH", SqlDbType.Text).Value = maKhoa;

                            //Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                            //Program.sqlcmd.ExecuteNonQuery();
                            //Program.conn.Close();
                            //String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                            //if (Ret == "1")
                            //    MessageBox.Show("Undo success");
                            //else
                            //    MessageBox.Show("Undo failed");

                            reload();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                }
            }

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void reload()
        {
            if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            {
                bdsDsLop.CancelEdit();

                if (btnThem.Enabled == false) bdsDsLop.Position = vitri;
                gcLop.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

            }
            else
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
            bdsDsLop.Position = vitri;

        }

        private void updateUIButtonPhucHoi()
        {
            if (st.Count == 0)
                btnPhucHoi.Enabled = false;
            else
                btnPhucHoi.Enabled = true;
        }

        private bool kiemTraTenLop(String tenLop)
        {
            try
            {

                String sql = "exec sp_KiemTraTenLop N'" + tenLop + "'";
                DataTable tb = Program.ExecSqlDataTable(sql);
                return (tb.Columns.Count == 0);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return false;
        }

        private bool checkInfoAvailable()
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }

            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }

            return true;
        }

        private bool kiemTraMaLop(String maLop)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.sp_TIMLOP ";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.Text).Value = maLop;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            return (Ret != "1");
        }

        private String layMaKhoaTheoTenKhoa(String tenKhoa)
        {
            String ma = "";

            String sql = "exec sp_LayMaKhoaTheoTenKhoa N'" + maKhoa + "'";
            DataTable tb = Program.ExecSqlDataTable(sql);
            if (tb.Rows.Count > 0)
            {
                try
                {
                    ma = tb.Rows[0]["MAKH"].ToString();
                }
                catch (Exception e)
                {
                    ma = null;
                }
            }

            return ma;
        }
    }

    public class Lop
    {
        public String maLop;
        public String tenLop;
        public String maKhoa;

        public Lop(String maLop, String tenLop, String maKhoa)
        {
            this.maLop = maLop;
            this.maKhoa = maKhoa;
            this.tenLop = tenLop;
        }
    }


}
