using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
            btnDangNhap.PerformClick();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void HienThiMenu()
        {
            MAGV.Text = "Mã Giảng Viên : " + Program.username;
            TENGV.Text = "Tên Giảng Viên : " + Program.mHoten;
            KHOA.Text = "Nhóm : " + Program.mGroup;
            // Phân quyền
        }

        private void btnLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                FormLop f = new FormLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                formDangNhap f = new formDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                FormSinhVien f = new FormSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormMonHoc f = new FormMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormDiem f = new FormDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

       
    }
}
