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
            // TODO: This line of code loads data into the 'dsKhoa.V_DS_PHANMANG' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANGTableAdapter.Fill(this.dsKhoa.V_DS_PHANMANG);
      
        }

       
    }
}
