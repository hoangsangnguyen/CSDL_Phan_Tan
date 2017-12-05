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
    public partial class formRP_Diem : Form
    {
        public String maLop;
        public String tenLop;
        public String monHoc;
        public String maMH;
        public String lanThi;
        public formRP_Diem()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String strLenh = "EXEC sp_LayDiemSinhVien N'" + maLop + "', N'" + maMH + "', N'" + lanThi+ "'";
            //MessageBox.Show(strLenh);
            dt = Program.ExecSqlDataTable(strLenh);
            
            rp_DsDiem rp = new rp_DsDiem();


            rp.SetDataSource(dt);
            rp.SetParameterValue("txtLop", tenLop);
            rp.SetParameterValue("txtMonHoc", monHoc);
            rp.SetParameterValue("txtLanThi", lanThi);
            crystalReportViewer2.ReportSource = rp;
        }
    }
}
