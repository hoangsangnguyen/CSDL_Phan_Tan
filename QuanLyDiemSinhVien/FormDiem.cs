using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            DataTable table = new DataTable("DiemEdit");
            table.Columns.Add("MASV", typeof(string));
            table.Columns.Add("MAMH", typeof(string));
            table.Columns.Add("LAN", typeof(int));
            table.Columns.Add("DIEM", typeof(float));

            String maSv = "";
            String maMH = cmbTenMonHoc.SelectedValue.ToString();
            int lan = Int32.Parse(txtLan.Text.ToString());
            float diem = 0;
            foreach (DataRowView row in bdsLayDiemSinhVien)
            {
                maSv = row["MASV"].ToString().Trim();

                if (row["Diem"].ToString().Trim() != "")
                {
                    diem = float.Parse(row["Diem"].ToString());
                    table.Rows.Add(maSv, maMH, lan, diem);
                    MessageBox.Show(maSv);
                }

            }

            MessageBox.Show("" + table.Rows.Count);

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenhKiemTraTenLop = "dbo.sp_InsertAndUpdateDiem ";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenhKiemTraTenLop;
            Program.sqlcmd.Parameters.AddWithValue("@table_temp", table);
            Program.sqlcmd.Parameters.AddWithValue("@maKhoa", "cntt");

            SqlDataAdapter dpt = new SqlDataAdapter(Program.sqlcmd);
            DataTable ds = new DataTable();
            dpt.Fill(ds);

            MessageBox.Show("end" + ds.Rows.Count);
            foreach (DataRow row in ds.Rows)
            {
                MessageBox.Show(row["MASV"].ToString() + ", " + row["LAN"].ToString() + row["DIEM"].ToString());
            }

        }


    }
}
