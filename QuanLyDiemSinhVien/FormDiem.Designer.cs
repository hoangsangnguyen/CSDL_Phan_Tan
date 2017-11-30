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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFunction = new System.Windows.Forms.GroupBox();
            this.btnReportDsDiem = new System.Windows.Forms.Button();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QuanLyDiemSinhVien.DS();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.lOPTableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.MONHOCTableAdapter();
            this.bdsLayDiemSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.LayDiemSinhVienTableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.sp_LayDiemSinhVienTableAdapter();
            this.gcDiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            this.groupBoxFunction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDiemSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(49, 38);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(55, 19);
            tENLOPLabel.TabIndex = 0;
            tENLOPLabel.Text = "Tên lớp";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(354, 36);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM MÔN HỌC";
            // 
            // groupBoxFunction
            // 
            this.groupBoxFunction.Controls.Add(this.btnReportDsDiem);
            this.groupBoxFunction.Controls.Add(this.cmbLan);
            this.groupBoxFunction.Controls.Add(this.cmbMaLop);
            this.groupBoxFunction.Controls.Add(this.btnLuu);
            this.groupBoxFunction.Controls.Add(this.btnBatDau);
            this.groupBoxFunction.Controls.Add(this.label2);
            this.groupBoxFunction.Controls.Add(tENMHLabel);
            this.groupBoxFunction.Controls.Add(this.cmbTenMonHoc);
            this.groupBoxFunction.Controls.Add(mALOPLabel);
            this.groupBoxFunction.Controls.Add(tENLOPLabel);
            this.groupBoxFunction.Controls.Add(this.cmbTenLop);
            this.groupBoxFunction.Location = new System.Drawing.Point(56, 62);
            this.groupBoxFunction.Name = "groupBoxFunction";
            this.groupBoxFunction.Size = new System.Drawing.Size(813, 182);
            this.groupBoxFunction.TabIndex = 1;
            this.groupBoxFunction.TabStop = false;
            // 
            // btnReportDsDiem
            // 
            this.btnReportDsDiem.Location = new System.Drawing.Point(524, 142);
            this.btnReportDsDiem.Name = "btnReportDsDiem";
            this.btnReportDsDiem.Size = new System.Drawing.Size(178, 23);
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
            // cmbMaLop
            // 
            this.cmbMaLop.DataSource = this.lOPBindingSource;
            this.cmbMaLop.DisplayMember = "MALOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(427, 28);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(128, 27);
            this.cmbMaLop.TabIndex = 10;
            this.cmbMaLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(627, 106);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(524, 106);
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
            this.label2.Location = new System.Drawing.Point(354, 106);
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
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.lOPBindingSource;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(147, 30);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(181, 27);
            this.cmbTenLop.TabIndex = 1;
            this.cmbTenLop.ValueMember = "TENLOP";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
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
            this.gcDiem.Location = new System.Drawing.Point(0, 269);
            this.gcDiem.MainView = this.gridView1;
            this.gcDiem.Name = "gcDiem";
            this.gcDiem.Size = new System.Drawing.Size(894, 341);
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
            this.colHOTEN.Caption = "HỌ TÊN";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDiem
            // 
            this.colDiem.Caption = "ĐIỂM";
            this.colDiem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiem.FieldName = "Diem";
            this.colDiem.Name = "colDiem";
            this.colDiem.Visible = true;
            this.colDiem.VisibleIndex = 2;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 610);
            this.Controls.Add(this.gcDiem);
            this.Controls.Add(this.groupBoxFunction);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDiem";
            this.Text = "FormDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDiem_Load);
            this.groupBoxFunction.ResumeLayout(false);
            this.groupBoxFunction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLayDiemSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxFunction;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.BindingSource bdsLayDiemSinhVien;
        private DSTableAdapters.sp_LayDiemSinhVienTableAdapter LayDiemSinhVienTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDiem;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.Button btnReportDsDiem;
    }
}