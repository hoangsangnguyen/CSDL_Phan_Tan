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
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtUserName.Text; 
            Program.password = txtPassword.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChinhanh = cmbKhoa.SelectedIndex;
            Program.bds_dspm = v_DS_PHANMANGBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
           
            Program.frmMain.HienThiMenu();
            this.Hide();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsKhoa.V_DS_PHANMANG' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANGTableAdapter1.Fill(this.dsKhoa.V_DS_PHANMANG);
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
                Program.servername = cmbKhoa.SelectedValue.ToString();
        }

    }
}
