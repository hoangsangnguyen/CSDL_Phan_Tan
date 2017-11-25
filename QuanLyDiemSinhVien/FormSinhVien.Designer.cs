namespace QuanLyDiemSinhVien
{
    partial class FormSinhVien
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label nOISINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGHIHOCLabel;
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoaSV = new System.Windows.Forms.ComboBox();
            this.DsLopTheoKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QuanLyDiemSinhVien.DS();
            this.DsSinhVienTheoLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsSinhVienTheoLopTableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.sp_LayDsSinhVienTheoLopTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.DSTableAdapters.TableAdapterManager();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DsLopTheoKhoaTableAdapter = new QuanLyDiemSinhVien.DSTableAdapters.sp_LayDsLopTheoKhoaTableAdapter();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoSV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.checkPhaiSV = new DevExpress.XtraEditors.CheckEdit();
            this.txtNgaySinhSV = new DevExpress.XtraEditors.DateEdit();
            this.txtNoiSinhSV = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChiSV = new DevExpress.XtraEditors.TextEdit();
            this.checkNghiHoc = new DevExpress.XtraEditors.CheckEdit();
            this.panelDetail = new System.Windows.Forms.Panel();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            nOISINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGHIHOCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsLopTheoKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSinhVienTheoLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPhaiSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinhSV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinhSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinhSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNghiHoc.Properties)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(31, 18);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(56, 19);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(31, 64);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(35, 19);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(31, 114);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(42, 19);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(290, 18);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(48, 19);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "PHAI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(290, 64);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(93, 19);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // nOISINHLabel
            // 
            nOISINHLabel.AutoSize = true;
            nOISINHLabel.Location = new System.Drawing.Point(290, 114);
            nOISINHLabel.Name = "nOISINHLabel";
            nOISINHLabel.Size = new System.Drawing.Size(78, 19);
            nOISINHLabel.TabIndex = 10;
            nOISINHLabel.Text = "NOISINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(570, 22);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(66, 19);
            dIACHILabel.TabIndex = 12;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGHIHOCLabel
            // 
            nGHIHOCLabel.AutoSize = true;
            nGHIHOCLabel.Location = new System.Drawing.Point(570, 66);
            nGHIHOCLabel.Name = "nGHIHOCLabel";
            nGHIHOCLabel.Size = new System.Drawing.Size(85, 19);
            nGHIHOCLabel.TabIndex = 14;
            nGHIHOCLabel.Text = "NGHIHOC:";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnHieuChinh,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MaxItemId = 8;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = global::QuanLyDiemSinhVien.Properties.Resources.Button_Add_24_icon;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = global::QuanLyDiemSinhVien.Properties.Resources.Text_Edit_icon_24;
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::QuanLyDiemSinhVien.Properties.Resources.Delete_2_icon_24;
            this.btnXoa.ImageOptions.LargeImage = global::QuanLyDiemSinhVien.Properties.Resources.Delete_2_icon_24;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = global::QuanLyDiemSinhVien.Properties.Resources.Save_icon_24;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = global::QuanLyDiemSinhVien.Properties.Resources.Undo_icon_24;
            this.btnPhucHoi.Name = "btnPhucHoi";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = global::QuanLyDiemSinhVien.Properties.Resources.Button_Refresh_icon_24;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = global::QuanLyDiemSinhVien.Properties.Resources.Exit_24_icon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(895, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 483);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(895, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(895, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbKhoaSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 70);
            this.panel1.TabIndex = 4;
            // 
            // cmbLop
            // 
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(518, 21);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(174, 27);
            this.cmbLop.TabIndex = 3;
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa";
            // 
            // cmbKhoaSV
            // 
            this.cmbKhoaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoaSV.FormattingEnabled = true;
            this.cmbKhoaSV.Location = new System.Drawing.Point(182, 18);
            this.cmbKhoaSV.Name = "cmbKhoaSV";
            this.cmbKhoaSV.Size = new System.Drawing.Size(172, 27);
            this.cmbKhoaSV.TabIndex = 0;
            this.cmbKhoaSV.SelectedIndexChanged += new System.EventHandler(this.cmbKhoaSV_SelectedIndexChanged);
            // 
            // DsLopTheoKhoaBindingSource
            // 
            this.DsLopTheoKhoaBindingSource.DataMember = "sp_LayDsLopTheoKhoa";
            this.DsLopTheoKhoaBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DsSinhVienTheoLopBindingSource
            // 
            this.DsSinhVienTheoLopBindingSource.DataMember = "sp_LayDsSinhVienTheoLop";
            this.DsSinhVienTheoLopBindingSource.DataSource = this.dS;
            // 
            // DsSinhVienTheoLopTableAdapter
            // 
            this.DsSinhVienTheoLopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.sp_LayDsSinhVienTheoLopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.DsSinhVienTheoLopBindingSource;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSinhVien.Location = new System.Drawing.Point(0, 109);
            this.gcSinhVien.MainView = this.gridView1;
            this.gcSinhVien.MenuManager = this.barManager1;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(895, 220);
            this.gcSinhVien.TabIndex = 13;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colMALOP,
            this.colPHAI,
            this.colNGAYSINH,
            this.colNOISINH,
            this.colDIACHI,
            this.colNGHIHOC});
            this.gridView1.GridControl = this.gcSinhVien;
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
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.AllowEdit = false;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colNOISINH
            // 
            this.colNOISINH.FieldName = "NOISINH";
            this.colNOISINH.Name = "colNOISINH";
            this.colNOISINH.OptionsColumn.AllowEdit = false;
            this.colNOISINH.Visible = true;
            this.colNOISINH.VisibleIndex = 6;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 7;
            // 
            // colNGHIHOC
            // 
            this.colNGHIHOC.FieldName = "NGHIHOC";
            this.colNGHIHOC.Name = "colNGHIHOC";
            this.colNGHIHOC.OptionsColumn.AllowEdit = false;
            this.colNGHIHOC.Visible = true;
            this.colNGHIHOC.VisibleIndex = 8;
            // 
            // DsLopTheoKhoaTableAdapter
            // 
            this.DsLopTheoKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DsSinhVienTheoLopBindingSource, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(93, 15);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(124, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtHoSV
            // 
            this.txtHoSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DsSinhVienTheoLopBindingSource, "HO", true));
            this.txtHoSV.Location = new System.Drawing.Point(93, 61);
            this.txtHoSV.MenuManager = this.barManager1;
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(124, 20);
            this.txtHoSV.TabIndex = 3;
            // 
            // txtTenSV
            // 
            this.txtTenSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DsSinhVienTheoLopBindingSource, "TEN", true));
            this.txtTenSV.Location = new System.Drawing.Point(93, 111);
            this.txtTenSV.MenuManager = this.barManager1;
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(124, 20);
            this.txtTenSV.TabIndex = 5;
            // 
            // checkPhaiSV
            // 
            this.checkPhaiSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DsSinhVienTheoLopBindingSource, "PHAI", true));
            this.checkPhaiSV.Location = new System.Drawing.Point(398, 19);
            this.checkPhaiSV.MenuManager = this.barManager1;
            this.checkPhaiSV.Name = "checkPhaiSV";
            this.checkPhaiSV.Properties.Caption = "Nam";
            this.checkPhaiSV.Size = new System.Drawing.Size(100, 19);
            this.checkPhaiSV.TabIndex = 7;
            // 
            // txtNgaySinhSV
            // 
            this.txtNgaySinhSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DsSinhVienTheoLopBindingSource, "NGAYSINH", true));
            this.txtNgaySinhSV.EditValue = null;
            this.txtNgaySinhSV.Location = new System.Drawing.Point(398, 63);
            this.txtNgaySinhSV.MenuManager = this.barManager1;
            this.txtNgaySinhSV.Name = "txtNgaySinhSV";
            this.txtNgaySinhSV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinhSV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinhSV.Size = new System.Drawing.Size(100, 20);
            this.txtNgaySinhSV.TabIndex = 9;
            // 
            // txtNoiSinhSV
            // 
            this.txtNoiSinhSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DsSinhVienTheoLopBindingSource, "NOISINH", true));
            this.txtNoiSinhSV.Location = new System.Drawing.Point(398, 111);
            this.txtNoiSinhSV.MenuManager = this.barManager1;
            this.txtNoiSinhSV.Name = "txtNoiSinhSV";
            this.txtNoiSinhSV.Size = new System.Drawing.Size(100, 20);
            this.txtNoiSinhSV.TabIndex = 11;
            // 
            // txtDiaChiSV
            // 
            this.txtDiaChiSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DsSinhVienTheoLopBindingSource, "DIACHI", true));
            this.txtDiaChiSV.Location = new System.Drawing.Point(667, 18);
            this.txtDiaChiSV.MenuManager = this.barManager1;
            this.txtDiaChiSV.Name = "txtDiaChiSV";
            this.txtDiaChiSV.Size = new System.Drawing.Size(182, 20);
            this.txtDiaChiSV.TabIndex = 13;
            // 
            // checkNghiHoc
            // 
            this.checkNghiHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.DsSinhVienTheoLopBindingSource, "NGHIHOC", true));
            this.checkNghiHoc.Location = new System.Drawing.Point(667, 66);
            this.checkNghiHoc.MenuManager = this.barManager1;
            this.checkNghiHoc.Name = "checkNghiHoc";
            this.checkNghiHoc.Properties.Caption = "";
            this.checkNghiHoc.Size = new System.Drawing.Size(75, 19);
            this.checkNghiHoc.TabIndex = 15;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(nGHIHOCLabel);
            this.panelDetail.Controls.Add(this.checkNghiHoc);
            this.panelDetail.Controls.Add(dIACHILabel);
            this.panelDetail.Controls.Add(this.txtDiaChiSV);
            this.panelDetail.Controls.Add(nOISINHLabel);
            this.panelDetail.Controls.Add(this.txtNoiSinhSV);
            this.panelDetail.Controls.Add(nGAYSINHLabel);
            this.panelDetail.Controls.Add(this.txtNgaySinhSV);
            this.panelDetail.Controls.Add(pHAILabel);
            this.panelDetail.Controls.Add(this.checkPhaiSV);
            this.panelDetail.Controls.Add(tENLabel);
            this.panelDetail.Controls.Add(this.txtTenSV);
            this.panelDetail.Controls.Add(hOLabel);
            this.panelDetail.Controls.Add(this.txtHoSV);
            this.panelDetail.Controls.Add(mASVLabel);
            this.panelDetail.Controls.Add(this.txtMaSV);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetail.Location = new System.Drawing.Point(0, 329);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(895, 154);
            this.panelDetail.TabIndex = 18;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 483);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.gcSinhVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsLopTheoKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsSinhVienTheoLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPhaiSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinhSV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinhSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinhSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkNghiHoc.Properties)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhoaSV;
        private System.Windows.Forms.Label label2;
        private DS dS;
        private System.Windows.Forms.BindingSource DsSinhVienTheoLopBindingSource;
        private DSTableAdapters.sp_LayDsSinhVienTheoLopTableAdapter DsSinhVienTheoLopTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
        private System.Windows.Forms.BindingSource DsLopTheoKhoaBindingSource;
        private DSTableAdapters.sp_LayDsLopTheoKhoaTableAdapter DsLopTheoKhoaTableAdapter;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Panel panelDetail;
        private DevExpress.XtraEditors.CheckEdit checkNghiHoc;
        private DevExpress.XtraEditors.TextEdit txtDiaChiSV;
        private DevExpress.XtraEditors.TextEdit txtNoiSinhSV;
        private DevExpress.XtraEditors.DateEdit txtNgaySinhSV;
        private DevExpress.XtraEditors.CheckEdit checkPhaiSV;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private DevExpress.XtraEditors.TextEdit txtHoSV;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
    }
}