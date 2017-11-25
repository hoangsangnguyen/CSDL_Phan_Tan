namespace QuanLyDiemSinhVien
{
    partial class formDangNhap
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
            System.Windows.Forms.Label tENCNLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsKhoa = new QuanLyDiemSinhVien.DsKhoa();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.v_DS_PHANMANGTableAdapter1 = new QuanLyDiemSinhVien.DsKhoaTableAdapters.V_DS_PHANMANGTableAdapter();
            this.tableAdapterManager = new QuanLyDiemSinhVien.DsKhoaTableAdapters.TableAdapterManager();
            tENCNLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(69, 38);
            tENCNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(68, 19);
            tENCNLabel.TabIndex = 1;
            tENCNLabel.Text = "TenKhoa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKhoa);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(tENCNLabel);
            this.groupBox1.Location = new System.Drawing.Point(76, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(522, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.v_DS_PHANMANGBindingSource;
            this.cmbKhoa.DisplayMember = "TENCN";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(196, 30);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(180, 27);
            this.cmbKhoa.TabIndex = 9;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged_1);
            // 
            // v_DS_PHANMANGBindingSource
            // 
            this.v_DS_PHANMANGBindingSource.DataMember = "V_DS_PHANMANG";
            this.v_DS_PHANMANGBindingSource.DataSource = this.dsKhoa;
            // 
            // dsKhoa
            // 
            this.dsKhoa.DataSetName = "DsKhoa";
            this.dsKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(300, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(196, 219);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(196, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "123456";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(196, 99);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 26);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "PT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // v_DS_PHANMANGTableAdapter1
            // 
            this.v_DS_PHANMANGTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLyDiemSinhVien.DsKhoaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 342);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDangNhap";
            this.Text = "formDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DsKhoa dsKhoa;
        private DsKhoaTableAdapters.V_DS_PHANMANGTableAdapter v_DS_PHANMANGTableAdapter1;
        private System.Windows.Forms.BindingSource v_DS_PHANMANGBindingSource;
        private DsKhoaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbKhoa;
    }
}