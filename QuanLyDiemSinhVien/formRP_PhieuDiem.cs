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
    public partial class formRP_PhieuDiem : Form
    {
        public formRP_PhieuDiem()
        {
            InitializeComponent();
        }

        private void btnInDiem_Click(object sender, EventArgs e)
        {
            String maSV = txtMaSV.Text.ToString();
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            String strLenh = "EXEC sp_InPhieuDiemCaNhan N'" + maSV + "'";
            String strLenh2 = "EXEC sp_TimSinhVienTheoMa N'" + maSV + "'";
            //MessageBox.Show(strLenh);
            dt = Program.ExecSqlDataTable(strLenh);
            dt2 = Program.ExecSqlDataTable(strLenh2);
            rp_InPhieuDiemCaNhan rp = new rp_InPhieuDiemCaNhan();

            rp.Database.Tables[0].SetDataSource(dt);
            rp.Database.Tables[1].SetDataSource(dt2);
            crystalReportViewer1.ReportSource = rp;

        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
