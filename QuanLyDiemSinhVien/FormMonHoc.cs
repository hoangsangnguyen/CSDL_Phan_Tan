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
    public partial class FormMonHoc : Form
    {
        public Stack st = new Stack();
        int choose = 0;

        int vitri = 0;
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = mONHOCBindingSource.Position;
            groupBox1.Enabled = true;
            mONHOCBindingSource.AddNew();

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            txtMaMH.Enabled = true;
            gcMonHoc.Enabled = false;
            choose = Program.THEM;
            btnPhucHoi.Enabled = true;
        }

        private void updateUIButtonPhucHoi()
        {
            if (st.Count == 0)
                btnPhucHoi.Enabled = false;
            else
                btnPhucHoi.Enabled = true;
        }
        private String convertStringToUTF8(String s)
        {
            var dbEnc = Encoding.UTF8;
            var uniEnc = Encoding.Unicode;
            byte[] dbByte = dbEnc.GetBytes(s);
            byte[] uniBytes = Encoding.Convert(dbEnc, uniEnc, dbByte);

            return uniEnc.GetString(uniBytes);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (choose)
            {
                case Program.THEM:
                    if (txtMaMH.Text.Trim() == "")
                    {
                        MessageBox.Show("Mã môn học không được thiếu!", "", MessageBoxButtons.OK);
                        txtMaMH.Focus();
                        return;
                    }

                    if (txtTenMH.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK);
                        txtTenMH.Focus();
                        return;
                    }

                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.sp_TIMMONHOC";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@X", SqlDbType.Text).Value = txtMaMH.Text;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret == "1")
                    {
                        MessageBox.Show("Mã môn học bị trùng!", "", MessageBoxButtons.OK);
                        txtMaMH.Focus();
                        Program.conn.Close();
                        return;
                    }

                    String strLenhKiemTra = "dbo.sp_KiemTraTenMonHoc";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenhKiemTra;
                    Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.Text).Value = convertStringToUTF8(txtTenMH.Text.Trim());
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String RetKiemTra = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (RetKiemTra == "1")
                    {
                        MessageBox.Show("Tên môn học bị trùng!", "", MessageBoxButtons.OK);
                        txtTenMH.Focus();
                        return;
                    }

                    try
                    {
                        mONHOCBindingSource.EndEdit();
                        mONHOCBindingSource.ResetCurrentItem();
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                        MessageBox.Show("Thêm lớp thành công", "", MessageBoxButtons.OK);

                        String lenh = "exec sp_UndoThemMonHoc '" + txtMaMH.Text + "'";
                        Program.ObjectUndo obj = new Program.ObjectUndo(Program.THEM, lenh);
                        st.Push(obj);
                        updateUIButtonPhucHoi();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcMonHoc.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;
                    break;

                case Program.HIEU_CHINH:
                    String tenMH = ((DataRowView)mONHOCBindingSource[vitri])["TENMH"].ToString().Trim();
                    if (txtTenMH.Text.Trim().Equals(tenMH))
                    {
                        if (MessageBox.Show("Bạn đã không thay đổi gì, bạn có muốn thoát chỉnh sửa ?", "Xác nhận",
                              MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            gcMonHoc.Enabled = true;
                            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                            btnGhi.Enabled = false;

                            groupBox1.Enabled = false;
                        }

                        return;
                    }

                    if (txtTenMH.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK);
                        txtTenMH.Focus();
                        return;
                    }

                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenhKiemTraTenLop = "dbo.sp_KiemTraTenMonHoc";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenhKiemTraTenLop;
                    Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.Text).Value = convertStringToUTF8(txtTenMH.Text.Trim());
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String RetKiemTraTenLop = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (RetKiemTraTenLop == "1")
                    {
                        MessageBox.Show("Tên lớp bị trùng!", "", MessageBoxButtons.OK);
                        txtTenMH.Focus();
                        return;
                    }

                    try
                    {
                        mONHOCBindingSource.EndEdit();
                        mONHOCBindingSource.ResetCurrentItem();
                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);

                        MessageBox.Show("Update thành công", "", MessageBoxButtons.OK);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiệu chỉnh nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    gcMonHoc.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                    btnGhi.Enabled = false;

                    groupBox1.Enabled = false;

                    break;
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = mONHOCBindingSource.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled =  btnExit.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnReload.Enabled = true;
            txtMaMH.Enabled = false;
            txtTenMH.Focus();
            gcMonHoc.Enabled = true;
            choose = Program.HIEU_CHINH;

            // lưu stack cho undo
            MonHoc mh = new MonHoc(txtMaMH.Text, txtTenMH.Text);
            Program.ObjectUndo obj = new Program.ObjectUndo(Program.HIEU_CHINH, mh);

            st.Push(obj);

            updateUIButtonPhucHoi();
        }
        public class MonHoc
        {
            public String maMonHoc;
            public String tenMonHoc;


            public MonHoc(String maMonHoc, String tenMonHoc)
            {
                this.maMonHoc = maMonHoc;
                this.tenMonHoc = tenMonHoc;
            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenhKiemTraTenLop = "dbo.sp_KiemTraMonHocTonTaiDiem";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenhKiemTraTenLop;
            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.Text).Value = convertStringToUTF8(txtMaMH.Text.Trim());
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String RetKiemTraTenLop = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (RetKiemTraTenLop == "1")
            {
                MessageBox.Show("Không thể xóa môn học này vì có điểm trong môn học", "",
                       MessageBoxButtons.OK);
                return;
            }

            String maMH = "";

            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DataRowView dataRow = (DataRowView)mONHOCBindingSource[mONHOCBindingSource.Position];
                    maMH = dataRow["MAMH"].ToString(); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    String tenMH = dataRow["TENMH"].ToString();
                    MonHoc mhRemove = new MonHoc(maMH, tenMH);
                    Program.ObjectUndo obj = new Program.ObjectUndo(Program.XOA, mhRemove);

                    mONHOCBindingSource.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);

                    st.Push(obj);
                    updateUIButtonPhucHoi();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    mONHOCBindingSource.Position = mONHOCBindingSource.Find("MAMH", maMH);
                    return;
                }
            }

            if (mONHOCBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }
        private void reload()
        {
            if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            {
                mONHOCBindingSource.CancelEdit();

                if (btnThem.Enabled == false) mONHOCBindingSource.Position = vitri;
                gcMonHoc.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

            }
            else
            {
                try
                {
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            {
                mONHOCBindingSource.CancelEdit();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

                if (btnThem.Enabled == false) mONHOCBindingSource.Position = vitri;
                gcMonHoc.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnExit.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

                reload();
            }
            else
            {

                if (st.Count == 0)
                    return;

                Program.ObjectUndo objUndo = (Program.ObjectUndo)st.Pop();
                Object obj = objUndo.obj;
                switch (objUndo.type)
                {
                    case Program.THEM:
                        MessageBox.Show("Khôi phục sau khi thêm");

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
                        this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                        updateUIButtonPhucHoi();

                        break;

                    case Program.HIEU_CHINH:
                        MessageBox.Show("Khôi phục sau khi hiệu chỉnh");
                        try
                        {
                            MonHoc mhChinh = (MonHoc)objUndo.obj;
                            MessageBox.Show(mhChinh.tenMonHoc);

                            if (Program.conn.State == ConnectionState.Closed)
                                Program.conn.Open();
                            String strLenh = "dbo.sp_UndoHieuChinh";
                            Program.sqlcmd = Program.conn.CreateCommand();
                            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.sqlcmd.CommandText = strLenh;
                            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.Text).Value = mhChinh.maMonHoc;
                            Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.Text).Value = convertStringToUTF8(mhChinh.tenMonHoc);

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
                        MessageBox.Show("Khôi phục sau khi xóa");
                        try
                        {
                            MonHoc mhXoa = (MonHoc)objUndo.obj;

                            if (Program.conn.State == ConnectionState.Closed)
                                Program.conn.Open();
                            String strLenh = "dbo.sp_InsertMonHoc";
                            Program.sqlcmd = Program.conn.CreateCommand();
                            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.sqlcmd.CommandText = strLenh;
                            Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.Text).Value = mhXoa.maMonHoc;
                            Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.Text).Value =convertStringToUTF8( mhXoa.tenMonHoc);

                            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                            Program.sqlcmd.ExecuteNonQuery();
                            Program.conn.Close();
                            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                            if (Ret == "1")
                                MessageBox.Show("Undo success");
                            else
                                MessageBox.Show("Undo failed");

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

    }
}
