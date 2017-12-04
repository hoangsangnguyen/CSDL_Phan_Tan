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
    public partial class formRP_DSSV : Form
    {
        public String maLop;
        public String tenLop;

        public formRP_DSSV()
        {
            InitializeComponent();

        }

        private void formRP_DSSV_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String strLenh = "EXEC sp_InDanhSachSinhVien N'" + maLop + "'";
            //MessageBox.Show(strLenh);
            dt = Program.ExecSqlDataTable(strLenh);
            rp_DSSV rp = new rp_DSSV();

            rp.SetDataSource(dt);
            rp.SetParameterValue("tenLop", tenLop);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
