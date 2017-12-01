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
    public partial class FormSinhVien : Form
    {
        int choose = 0;

        int vitri = 0;
        int vitriLop = 0;

        public Stack st = new Stack();

        public FormSinhVien()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            cmbKhoaSV.DataSource = new BindingSource(Program.bds_dspm, null);  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoaSV.DisplayMember = "TENCN";
            cmbKhoaSV.ValueMember = "TENSERVER";
            cmbKhoaSV.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "PGV")
                cmbKhoaSV.Enabled = true;  // bật tắt theo phân quyền
            else
                cmbKhoaSV.Enabled = false;

            initComboboxLop();
            initSinhVienList();
            panelDetail.Enabled = false;
            btnPhucHoi.Enabled = btnGhi.Enabled = false;

        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.DsSinhVienTheoLopTableAdapter.Fill(this.dS.sp_LayDsSinhVienTheoLop, cmbLop.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            this.DsSinhVienTheoLopTableAdapter.Connection.ConnectionString = Program.connstr;
        }

        private void cmbKhoaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            initComboboxLop();
        }

        private void initComboboxLop()
        {
            cmbKhoaSV.Enabled = true;
            try
            {

                String sql = "exec sp_LayDsLopTheoTenKhoa N'" + cmbKhoaSV.Text.ToString() + "'";
                DataTable tb = Program.ExecSqlDataTable(sql);
                if (tb.Columns.Count > 0)
                {
                    cmbLop.DataSource = tb;
                    cmbLop.DisplayMember = "TENLOP";
                    cmbLop.ValueMember = "MALOP";

                    cmbLop.SelectedIndex = 0;

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void initSinhVienList()
        {
            cmbLop.Enabled = true;
            try
            {
                this.DsSinhVienTheoLopTableAdapter.Fill(this.dS.sp_LayDsSinhVienTheoLop, cmbLop.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        private void reload()
        {
            vitriLop = cmbLop.SelectedIndex;
            int viTriKhoa = cmbKhoaSV.SelectedIndex;
            initComboboxLop();
            initSinhVienList();

            cmbKhoaSV.SelectedIndex = viTriKhoa;
            cmbLop.SelectedIndex = vitriLop;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = DsSinhVienTheoLopBindingSource.Position;
            panelDetail.Enabled = true;
            DsSinhVienTheoLopBindingSource.AddNew();
            checkPhaiSV.Checked = false;
            checkNghiHoc.Checked = false;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            gcSinhVien.Enabled = false;
            choose = Program.THEM;
            btnPhucHoi.Enabled = true;
            panelDetail.Enabled = true;
            cmbKhoaSV.Enabled = cmbLop.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = DsSinhVienTheoLopBindingSource.Position;
            panelDetail.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            txtMaSV.Enabled = false;
            txtHoSV.Focus();
            gcSinhVien.Enabled = false;
            choose = Program.HIEU_CHINH;

            // lưu stack cho undo
            SinhVien sv = new SinhVien(txtMaSV.Text.ToString(),
                                    txtHoSV.Text.ToString(),
                                    txtTenSV.Text.ToString(),
                                    checkPhaiSV.Checked,
                                    Program.convertStringToDateTime(txtNgaySinhSV.Text.ToString()),
                                    txtNoiSinhSV.Text.ToString(),
                                    txtDiaChiSV.Text.ToString(),
                                    checkNghiHoc.Checked);
            Program.ObjectUndo obj = new Program.ObjectUndo(Program.HIEU_CHINH, sv);
            st.Push(obj);
            updateUIButtonPhucHoi();

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (choose)
            {
                case Program.THEM:
                    if (checkAvailabelInfo())
                    {
                        xuLyThem(true, txtMaSV.Text.Trim(), txtHoSV.Text.Trim(), txtTenSV.Text.Trim(), cmbLop.SelectedValue.ToString(),
                                 checkPhaiSV.Checked, Program.convertStringToDateTime(txtNgaySinhSV.Text),
                                 txtNoiSinhSV.Text.Trim(), txtDiaChiSV.Text.Trim(), checkNghiHoc.Checked);
                    }
                    break;

                case Program.HIEU_CHINH:
                    if (checkAvailabelInfo())
                    {
                        xuLyHieuChinh(txtMaSV.Text.ToString(),
                                   txtHoSV.Text.ToString(),
                                   txtTenSV.Text.ToString(),
                                   checkPhaiSV.Checked,
                                   Program.convertStringToDateTime(txtNgaySinhSV.Text.ToString()),
                                   txtNoiSinhSV.Text.ToString(),
                                   txtDiaChiSV.Text.ToString(),
                                   checkNghiHoc.Checked);
                    }

                    break;

            };
        }

        private void xuLyThem(bool haveUndo, String maSV, String ho, String ten, String maLop,
                                bool phai, DateTime ngaySinh, String noiSinh, String diaChi, bool nghiHoc)
        {

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.sp_KiemTraMaSV";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.Text).Value = maSV;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "1")
            {
                MessageBox.Show("Mã sinh viên bị trùng!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                Program.conn.Close();
                return;
            }

            try
            {
                DsSinhVienTheoLopBindingSource.EndEdit();
                DsSinhVienTheoLopBindingSource.ResetCurrentItem();
                this.DsSinhVienTheoLopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DsSinhVienTheoLopTableAdapter.Insert(maSV, ho, ten, maLop, phai,
                                                            ngaySinh, noiSinh, diaChi, nghiHoc);

                vitriLop = cmbLop.SelectedIndex;
                reload();
                cmbLop.SelectedIndex = vitriLop;

                if (haveUndo)
                    MessageBox.Show("Thêm sinh viên thành công", "", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Phục hồi thành công", "", MessageBoxButtons.OK);


                if (haveUndo)
                {
                    Program.ObjectUndo obj = new Program.ObjectUndo(Program.THEM, maSV);
                    st.Push(obj);

                }
                updateUIButtonPhucHoi();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            gcSinhVien.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            cmbLop.Enabled = true;
            if (Program.mGroup == "PGV")
                cmbKhoaSV.Enabled = true;  // bật tắt theo phân quyền
            else
                cmbKhoaSV.Enabled = false;
            btnGhi.Enabled = false;

            panelDetail.Enabled = false;

        }
        private void xuLyHieuChinh(String maSV, String ho, String ten, bool phaiSV, DateTime ngaySinh,
                                    String noiSinh, String diaChi, bool nghiHoc)
        {
            try
            {
                DsSinhVienTheoLopBindingSource.EndEdit();
                DsSinhVienTheoLopBindingSource.ResetCurrentItem();
                this.DsSinhVienTheoLopTableAdapter.Connection.ConnectionString = Program.connstr;
                this.DsSinhVienTheoLopTableAdapter.Update(maSV, ho, ten, phaiSV, ngaySinh, noiSinh, diaChi, nghiHoc);

                MessageBox.Show("Hiệu chỉnh thành công", "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiệu chỉnh sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            gcSinhVien.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = false;

            panelDetail.Enabled = false;

            vitriLop = cmbLop.SelectedIndex;
            reload();
            cmbLop.SelectedIndex = vitriLop;

        }
        private bool checkAvailabelInfo()
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã Sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }

            if (txtHoSV.Text.Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtHoSV.Focus();
                return false;
            }

            if (txtTenSV.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTenSV.Focus();
                return false;
            }

            if (txtNgaySinhSV.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được thiếu!", "", MessageBoxButtons.OK);
                txtNgaySinhSV.Focus();
                return false;
            }

            if (txtNoiSinhSV.Text.Trim() == "")
            {
                MessageBox.Show("Nơi sinh không được thiếu!", "", MessageBoxButtons.OK);
                txtNoiSinhSV.Focus();
                return false;
            }

            if (txtDiaChiSV.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txtDiaChiSV.Focus();
                return false;
            }

            return true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xuLyXoaSinhVien(true, txtMaSV.Text.ToString());
        }

        private void xuLyXoaSinhVien(bool haveUndo, String maSV)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.sp_KiemTraMaSV";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MASV", SqlDbType.Text).Value = txtMaSV.Text.Trim();
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret == "0")
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "", MessageBoxButtons.OK);
                Program.conn.Close();
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên có mã " + maSV + " ??", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DataRowView dataRow = (DataRowView)DsSinhVienTheoLopBindingSource[DsSinhVienTheoLopBindingSource.Position];
                    String maSv = dataRow["MASV"].ToString();
                    String hoSv = dataRow["HO"].ToString();
                    String tenSv = dataRow["TEN"].ToString();
                    String maLop = dataRow["MALOP"].ToString();
                    bool phaiSv = Boolean.Parse(dataRow["PHAI"].ToString());
                    String ngaySinh = txtNgaySinhSV.Text.ToString();
                    String noiSinh = dataRow["NOISINH"].ToString();
                    String diaChi = dataRow["DIACHI"].ToString();
                    bool nghiHoc = Boolean.Parse(dataRow["NGHIHOC"].ToString());

                    SinhVien svRemove = new SinhVien(maSV, hoSv, tenSv, phaiSv, Program.convertStringToDateTime(ngaySinh),
                                                    noiSinh, diaChi, nghiHoc);
                    svRemove.maLop = maLop;

                    Program.ObjectUndo obj = new Program.ObjectUndo(Program.XOA, svRemove);

                    this.DsSinhVienTheoLopTableAdapter.Connection.ConnectionString = Program.connstr;
                    int result = this.DsSinhVienTheoLopTableAdapter.Delete(maSV);
                    if (result == 1) {
                        if (haveUndo)
                            MessageBox.Show("Xóa sinh viên thành công", "", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Phục hồi thành công", "", MessageBoxButtons.OK);

                    }
                    else
                    {
                        if (haveUndo)
                            MessageBox.Show("Xóa sinh viên bị lỗi", "", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Phục hồi bị lỗi", "", MessageBoxButtons.OK);

                    }

                    vitriLop = cmbLop.SelectedIndex;
                    reload();
                    cmbLop.SelectedIndex = vitriLop;

                    if (haveUndo)
                    {
                        st.Push(obj);
                        updateUIButtonPhucHoi();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    initSinhVienList();
                    DsSinhVienTheoLopBindingSource.Position = DsSinhVienTheoLopBindingSource.Find("MASV", txtMaSV.Text.Trim());
                    return;
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnHieuChinh.Enabled == false || btnThem.Enabled == false)
            {
                DsSinhVienTheoLopBindingSource.CancelEdit();
                this.DsSinhVienTheoLopTableAdapter.Connection.ConnectionString = Program.connstr;

                if (btnThem.Enabled == false) DsSinhVienTheoLopBindingSource.Position = vitri;
                gcSinhVien.Enabled = true;
                panelDetail.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
                btnGhi.Enabled = btnPhucHoi.Enabled = false;

                vitriLop = cmbLop.SelectedIndex;
                reload();
                cmbLop.SelectedIndex = vitriLop;
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

                        String maSV = "";

                        try
                        {
                            maSV = obj.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        xuLyXoaSinhVien(false, maSV);
                        updateUIButtonPhucHoi();

                        break;

                    case Program.HIEU_CHINH:
                        MessageBox.Show("Khôi phục sau khi hiệu chỉnh");
                        try
                        {
                            SinhVien sv = (SinhVien)objUndo.obj;
                            xuLyHieuChinh(sv.maSinhVien, sv.hoSinhVien, sv.tenSinhVien,
                                            sv.phaiSinhVien, sv.ngaySinh, sv.noiSinh, sv.diaChi, sv.nghiHoc);
                            updateUIButtonPhucHoi();
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
                            SinhVien svXoa = (SinhVien)objUndo.obj;
                            xuLyThem(false, svXoa.maSinhVien, svXoa.hoSinhVien, svXoa.tenSinhVien,
                                           svXoa.maLop, svXoa.phaiSinhVien, svXoa.ngaySinh,
                                           svXoa.noiSinh, svXoa.diaChi, svXoa.nghiHoc);
                            updateUIButtonPhucHoi();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                }
            }
        }

        private void updateUIButtonPhucHoi()
        {
            if (st.Count == 0)
                btnPhucHoi.Enabled = false;
            else
                btnPhucHoi.Enabled = true;
        }

        public class SinhVien
        {
            public String maSinhVien;
            public String hoSinhVien;
            public String tenSinhVien;
            public String maLop;
            public bool phaiSinhVien;
            public DateTime ngaySinh;
            public String noiSinh;
            public String diaChi;
            public bool nghiHoc;

            public SinhVien(String maSinhVien, String hoSinhVien, String tenSinhVien, bool phaiSinhVien, DateTime ngaySinh,
                         String noiSinh, String diaChi, bool nghiHoc)
            {
                this.maSinhVien = maSinhVien;
                this.hoSinhVien = hoSinhVien;
                this.tenSinhVien = tenSinhVien;
                this.phaiSinhVien = phaiSinhVien;
                this.ngaySinh = ngaySinh;
                this.noiSinh = noiSinh;
                this.diaChi = diaChi;
                this.nghiHoc = nghiHoc;
            }
        }

        private void btnInDanhSachSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
            String maLop = cmbLop.SelectedValue.ToString();
            String tenLop = cmbLop.Text.ToString();
            Form frm = this.CheckExists(typeof(formRP_DSSV));
            if (frm != null) frm.Activate();
            else
            {
                formRP_DSSV f = new formRP_DSSV();
                f.maLop = maLop;
                f.tenLop = tenLop;
                f.Show();
            }
        }
    }
}
