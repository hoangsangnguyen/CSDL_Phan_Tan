﻿using System;
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
        const int THEM = 0;
        const int HIEU_CHINH = 1;
        const int XOA = 2;

        int vitri = 0;

        public FormSinhVien()
        {
            InitializeComponent();
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
            initComboboxLop();
            initSinhVienList();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = DsSinhVienTheoLopBindingSource.Position;
            panelDetail.Enabled = true;
            DsSinhVienTheoLopBindingSource.AddNew();

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnReload.Enabled = true;
            gcSinhVien.Enabled = false;
            choose = THEM;
            btnPhucHoi.Enabled = true;

            cmbKhoaSV.Enabled = cmbLop.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (choose)
            {
                case THEM:
                    if (checkAvailabelInfo())
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
                            this.DsSinhVienTheoLopTableAdapter.Insert(txtMaSV.Text.Trim(),
                                                                        txtHoSV.Text.Trim(),
                                                                        txtTenSV.Text.Trim(),
                                                                        cmbLop.SelectedValue.ToString().Trim(),
                                                                        checkPhaiSV.Checked,
                                                                        convertStringToDateTime(txtNgaySinhSV.Text),
                                                                        txtNoiSinhSV.Text.Trim(),
                                                                        txtDiaChiSV.Text.Trim(),
                                                                        checkNghiHoc.Checked);

                            MessageBox.Show("Thêm lớp thành công", "", MessageBoxButtons.OK);

                            //String lenh = "exec sp_UndoThemLop '" + txtMaSV.Text + "'";
                            //ObjectUndo obj = new ObjectUndo(THEM, lenh);
                            //st.Push(obj);
                            //updateUIButtonPhucHoi();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                    }


                    break;

                case HIEU_CHINH:
                    break;


            };
        }

        private bool checkAvailabelInfo()
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }

            if (txtHoSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtHoSV.Focus();
                return false;
            }

            if (txtTenSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtTenSV.Focus();
                return false;
            }

            if (txtNgaySinhSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtNgaySinhSV.Focus();
                return false;
            }

            if (txtNoiSinhSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtNoiSinhSV.Focus();
                return false;
            }

            if (txtDiaChiSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtDiaChiSV.Focus();
                return false;
            }

            return true;
        }

        private DateTime convertStringToDateTime(String s)
        {
            return DateTime.ParseExact(s, "MM/dd/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}