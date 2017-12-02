namespace QuanLyDiemSinhVien
{
    partial class FormDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mAKHLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFunction = new System.Windows.Forms.GroupBox();
            this.btnInPhieuDiemThi = new System.Windows.Forms.Button();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QuanLyDiemSinhVien.DS();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInDiemCaNhan = new System.Windows.Forms.Button();
            this.btnReportDsDiem = new System.Windows.Forms.Button();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new QuanLyDiemSinhVien.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.MONHOCTableAdapter();
            this.bdsLayDiemSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.LayDiemSinhVienTableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.sp_LayDiemSinhVienTableAdapter();
            this.gcDiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kHOATableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.KHOATableAdapter();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.LOPTableAdapter();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            this.groupBoxFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDiemSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(366, 43);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(55, 19);
            tENLOPLabel.TabIndex = 0;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(652, 45);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(53, 19);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "Mã lớp";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(49, 106);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(88, 19);
            tENMHLabel.TabIndex = 4;
            tENMHLabel.Text = "Tên môn học";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(49, 40);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(70, 19);
            mAKHLabel.TabIndex = 14;
            mAKHLabel.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM MÔN HỌC";
            // 
            // groupBoxFunction
            // 
            this.groupBoxFunction.Controls.Add(this.btnInPhieuDiemThi);
            this.groupBoxFunction.Controls.Add(this.cmbMaLop);
            this.groupBoxFunction.Controls.Add(this.cmbTenLop);
            this.groupBoxFunction.Controls.Add(mAKHLabel);
            this.groupBoxFunction.Controls.Add(this.cmbKhoa);
            this.groupBoxFunction.Controls.Add(this.btnThoat);
            this.groupBoxFunction.Controls.Add(this.btnInDiemCaNhan);
            this.groupBoxFunction.Controls.Add(this.btnReportDsDiem);
            this.groupBoxFunction.Controls.Add(this.cmbLan);
            this.groupBoxFunction.Controls.Add(this.btnLuu);
            this.groupBoxFunction.Controls.Add(this.btnBatDau);
            this.groupBoxFunction.Controls.Add(this.label2);
            this.groupBoxFunction.Controls.Add(tENMHLabel);
            this.groupBoxFunction.Controls.Add(this.cmbTenMonHoc);
            this.groupBoxFunction.Controls.Add(mALOPLabel);
            this.groupBoxFunction.Controls.Add(tENLOPLabel);
            this.groupBoxFunction.Location = new System.Drawing.Point(0, 62);
            this.groupBoxFunction.Name = "groupBoxFunction";
            this.groupBoxFunction.Size = new System.Drawing.Size(959, 218);
            this.groupBoxFunction.TabIndex = 1;
            this.groupBoxFunction.TabStop = false;
            // 
            // btnInPhieuDiemThi
            // 
            this.btnInPhieuDiemThi.Location = new System.Drawing.Point(548, 154);
            this.btnInPhieuDiemThi.Name = "btnInPhieuDiemThi";
            this.btnInPhieuDiemThi.Size = new System.Drawing.Size(157, 23);
            this.btnInPhieuDiemThi.TabIndex = 18;
            this.btnInPhieuDiemThi.Text = "In Phiếu Điểm Thi";
            this.btnInPhieuDiemThi.UseVisualStyleBackColor = true;
            this.btnInPhieuDiemThi.Click += new System.EventHandler(this.btnInPhieuDiemThi_Click);
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(711, 40);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(137, 27);
            this.cmbMaLop.TabIndex = 17;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(427, 40);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(202, 27);
            this.cmbTenLop.TabIndex = 16;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.kHOABindingSource;
            this.cmbKhoa.DisplayMember = "MAKH";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(147, 37);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(181, 27);
            this.cmbKhoa.TabIndex = 15;
            this.cmbKhoa.ValueMember = "TENKH";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(719, 154);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInDiemCaNhan
            // 
            this.btnInDiemCaNhan.Location = new System.Drawing.Point(405, 155);
            this.btnInDiemCaNhan.Name = "btnInDiemCaNhan";
            this.btnInDiemCaNhan.Size = new System.Drawing.Size(136, 23);
            this.btnInDiemCaNhan.TabIndex = 13;
            this.btnInDiemCaNhan.Text = "In Điểm Cá Nhân";
            this.btnInDiemCaNhan.UseVisualStyleBackColor = true;
            this.btnInDiemCaNhan.Click += new System.EventHandler(this.btnInDiemCaNhan_Click);
            // 
            // btnReportDsDiem
            // 
            this.btnReportDsDiem.Location = new System.Drawing.Point(266, 155);
            this.btnReportDsDiem.Name = "btnReportDsDiem";
            this.btnReportDsDiem.Size = new System.Drawing.Size(133, 23);
            this.btnReportDsDiem.TabIndex = 12;
            this.btnReportDsDiem.Text = "In danh sách điểm";
            this.btnReportDsDiem.UseVisualStyleBackColor = true;
            this.btnReportDsDiem.Click += new System.EventHandler(this.btnReportDsDiem_Click);
            // 
            // cmbLan
            // 
            this.cmbLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(427, 102);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(65, 27);
            this.cmbLan.TabIndex = 11;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(162, 155);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(53, 155);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(75, 23);
            this.btnBatDau.TabIndex = 8;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lần";
            // 
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.DataSource = this.mONHOCBindingSource;
            this.cmbTenMonHoc.DisplayMember = "TENMH";
            this.cmbTenMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(147, 98);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(181, 27);
            this.cmbTenMonHoc.TabIndex = 5;
            this.cmbTenMonHoc.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.sp_LayDsSinhVienTheoLopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsLayDiemSinhVien
            // 
            this.bdsLayDiemSinhVien.DataMember = "sp_LayDiemSinhVien";
            this.bdsLayDiemSinhVien.DataSource = this.dS;
            // 
            // LayDiemSinhVienTableAdapter
            // 
            this.LayDiemSinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // gcDiem
            // 
            this.gcDiem.DataSource = this.bdsLayDiemSinhVien;
            this.gcDiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDiem.Location = new System.Drawing.Point(0, 296);
            this.gcDiem.MainView = this.gridView1;
            this.gcDiem.Name = "gcDiem";
            this.gcDiem.Size = new System.Drawing.Size(959, 314);
            this.gcDiem.TabIndex = 2;
            this.gcDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDiem});
            this.gridView1.GridControl = this.gcDiem;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDiem
            // 
            this.colDiem.FieldName = "Diem";
            this.colDiem.Name = "colDiem";
            this.colDiem.Visible = true;
            this.colDiem.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "FK_KHOA_LOP";
            this.lOPBindingSource.DataSource = this.kHOABindingSource;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDiem);
            this.Controls.Add(this.groupBoxFunction);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDiem";
            this.Text = "FormDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDiem_Load);
            this.groupBoxFunction.ResumeLayout(false);
            this.groupBoxFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDiemSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxFunction;
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.BindingSource bdsLayDiemSinhVien;
        private DSTableAdapters.sp_LayDiemSinhVienTableAdapter LayDiemSinhVienTableAdapter;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.Button btnReportDsDiem;
        private DevExpress.XtraGrid.GridControl gcDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDiem;
        private System.Windows.Forms.Button btnInDiemCaNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.Button btnInPhieuDiemThi;
    }
}