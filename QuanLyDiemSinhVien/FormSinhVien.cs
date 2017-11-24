using System;
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

            initComboboxLop(cmbKhoaSV.Text.ToString());

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
            initComboboxLop(cmbKhoaSV.Text.ToString());
        }

        private void initComboboxLop(String tenKhoa)
        {
            try
            {

                String sql = "exec sp_LayDsLopTheoTenKhoa N'" + tenKhoa + "'";
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
    }
}
