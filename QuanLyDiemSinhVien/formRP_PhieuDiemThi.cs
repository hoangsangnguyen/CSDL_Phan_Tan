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
    public partial class formRP_PhieuDiemThi : Form
    {
        public String monHoc;
        public String tenLop;
        public String maLop;

        public formRP_PhieuDiemThi()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String strLenh = "EXEC sp_InDsSinhVienTheoLop N'" + maLop + "'";
            //MessageBox.Show(strLenh);
            dt = Program.ExecSqlDataTable(strLenh);
            RP_InPhieuDiemThi rp = new RP_InPhieuDiemThi();
           
            rp.SetDataSource(dt);
            rp.SetParameterValue("TENLOP", tenLop);
            rp.SetParameterValue("MONHOC", monHoc);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
