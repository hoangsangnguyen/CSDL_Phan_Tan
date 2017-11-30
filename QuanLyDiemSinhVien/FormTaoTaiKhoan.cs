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
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dsKhoa.V_DS_PHANMANG' table. You can move, or remove it, as needed.
            
            this.v_DS_PHANMANGTableAdapter.Fill(this.dsKhoa.V_DS_PHANMANG);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
          
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;
            cmbMaGV.SelectedIndex = 1;
            cmbMaGV.SelectedIndex = 0;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
                Program.servername = cmbKhoa.SelectedValue.ToString();
        }



       
    }
}
