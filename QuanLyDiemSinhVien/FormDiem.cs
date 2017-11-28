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
    public partial class FormDiem : Form
    {
        public FormDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormDiem_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.lOPTableAdapter.Fill(this.dS.LOP);

            gcDiem.Hide();
            
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            gcDiem.Show();
            initGcMaSvHoTenSinhVien();
            groupBoxFunction.Enabled = false;
            
        }

        private void initGcMaSvHoTenSinhVien()
        {
            try
            {
                this.LayDiemSinhVienTableAdapter.Fill(this.dS.sp_LayDiemSinhVien, txtMaLop.Text,
                                                        cmbTenMonHoc.SelectedValue.ToString(),
                                                        short.Parse(txtLan.Text));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            this.LayDiemSinhVienTableAdapter.Connection.ConnectionString = Program.connstr;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            

        }


    }
}
