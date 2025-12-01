namespace ABCCoffee.GUI.UserControls
{
    partial class UC_Manage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcManagement = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddAccount = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnReloadAccount = new Guna.UI2.WinForms.Guna2Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAccountList = new System.Windows.Forms.GroupBox();
            this.dgvAccountList = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.gbTableList = new System.Windows.Forms.GroupBox();
            this.dgvTableList = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveTable = new Guna.UI2.WinForms.Guna2Button();
            this.tcManagement.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbAccountList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.gbTableList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManagement
            // 
            this.tcManagement.Controls.Add(this.tpAccount);
            this.tcManagement.Controls.Add(this.tpTable);
            this.tcManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tcManagement.ItemSize = new System.Drawing.Size(180, 40);
            this.tcManagement.Location = new System.Drawing.Point(0, 0);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(1124, 483);
            this.tcManagement.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcManagement.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcManagement.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcManagement.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcManagement.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcManagement.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcManagement.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcManagement.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcManagement.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcManagement.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcManagement.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcManagement.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcManagement.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcManagement.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcManagement.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcManagement.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcManagement.TabIndex = 0;
            this.tcManagement.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcManagement.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel1);
            this.tpAccount.Controls.Add(this.gbAccountList);
            this.tpAccount.Controls.Add(this.flowLayoutPanel2);
            this.tpAccount.Location = new System.Drawing.Point(4, 44);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(1116, 435);
            this.tpAccount.TabIndex = 0;
            this.tpAccount.Text = "Nhân viên";
            this.tpAccount.UseVisualStyleBackColor = true;
            this.tpAccount.Enter += new System.EventHandler(this.tpAccount_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddAccount);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.btnReloadAccount);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbDisplayName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbAccountName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(765, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 369);
            this.panel1.TabIndex = 3;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BorderThickness = 1;
            this.btnAddAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Location = new System.Drawing.Point(76, 334);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(7);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(78, 28);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(148, 244);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(167, 26);
            this.dtpDateOfBirth.TabIndex = 28;
            // 
            // btnReloadAccount
            // 
            this.btnReloadAccount.BorderThickness = 1;
            this.btnReloadAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReloadAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReloadAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReloadAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReloadAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnReloadAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReloadAccount.ForeColor = System.Drawing.Color.Black;
            this.btnReloadAccount.Location = new System.Drawing.Point(190, 334);
            this.btnReloadAccount.Margin = new System.Windows.Forms.Padding(7);
            this.btnReloadAccount.Name = "btnReloadAccount";
            this.btnReloadAccount.Size = new System.Drawing.Size(75, 28);
            this.btnReloadAccount.TabIndex = 7;
            this.btnReloadAccount.Text = "Tải lại";
            this.btnReloadAccount.Click += new System.EventHandler(this.btnReloadAccount_Click);
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý",
            "Khác"});
            this.cbRole.Location = new System.Drawing.Point(148, 289);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(167, 28);
            this.cbRole.TabIndex = 27;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGender.Location = new System.Drawing.Point(148, 152);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(167, 28);
            this.cbGender.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Vai trò";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ngày sinh";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(148, 199);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(167, 26);
            this.tbPhone.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giới tính";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(148, 107);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(167, 26);
            this.tbPassword.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mật khẩu";
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(148, 62);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(167, 26);
            this.tbDisplayName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Họ và tên";
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(148, 17);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(167, 26);
            this.tbAccountName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tài khoản";
            // 
            // gbAccountList
            // 
            this.gbAccountList.Controls.Add(this.dgvAccountList);
            this.gbAccountList.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbAccountList.Location = new System.Drawing.Point(3, 63);
            this.gbAccountList.Name = "gbAccountList";
            this.gbAccountList.Size = new System.Drawing.Size(762, 369);
            this.gbAccountList.TabIndex = 2;
            this.gbAccountList.TabStop = false;
            this.gbAccountList.Text = "Danh sách tài khoản";
            // 
            // dgvAccountList
            // 
            this.dgvAccountList.AllowUserToAddRows = false;
            this.dgvAccountList.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccountList.GridColor = System.Drawing.Color.White;
            this.dgvAccountList.Location = new System.Drawing.Point(3, 22);
            this.dgvAccountList.MultiSelect = false;
            this.dgvAccountList.Name = "dgvAccountList";
            this.dgvAccountList.ReadOnly = true;
            this.dgvAccountList.RowHeadersVisible = false;
            this.dgvAccountList.RowHeadersWidth = 51;
            this.dgvAccountList.RowTemplate.Height = 24;
            this.dgvAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountList.ShowCellErrors = false;
            this.dgvAccountList.ShowCellToolTips = false;
            this.dgvAccountList.ShowRowErrors = false;
            this.dgvAccountList.Size = new System.Drawing.Size(756, 344);
            this.dgvAccountList.TabIndex = 0;
            this.dgvAccountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountList_CellClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnEdit);
            this.flowLayoutPanel2.Controls.Add(this.btnRemoveAccount);
            this.flowLayoutPanel2.Controls.Add(this.btnExport);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.tbSearch);
            this.flowLayoutPanel2.Controls.Add(this.btnSearch);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.cbSearchBy);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1110, 60);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(17, 17);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(63, 28);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.BorderThickness = 1;
            this.btnRemoveAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRemoveAccount.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveAccount.Location = new System.Drawing.Point(94, 17);
            this.btnRemoveAccount.Margin = new System.Windows.Forms.Padding(7);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(68, 28);
            this.btnRemoveAccount.TabIndex = 6;
            this.btnRemoveAccount.Text = "Xóa";
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // btnExport
            // 
            this.btnExport.BorderThickness = 1;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.Transparent;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(176, 17);
            this.btnExport.Margin = new System.Windows.Forms.Padding(7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(68, 28);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Xuất";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(258, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSearch.Location = new System.Drawing.Point(582, 17);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(7, 7, 0, 7);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(176, 28);
            this.tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.CustomImages.Image = global::ABCCoffee.Properties.Resources.icon_search;
            this.btnSearch.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(760, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 7, 7, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(806, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm theo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Tài khoản",
            "Họ và tên",
            "Số điện thoại"});
            this.cbSearchBy.Location = new System.Drawing.Point(957, 17);
            this.cbSearchBy.Margin = new System.Windows.Forms.Padding(7);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(133, 28);
            this.cbSearchBy.TabIndex = 3;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.gbTableList);
            this.tpTable.Controls.Add(this.flowLayoutPanel1);
            this.tpTable.Location = new System.Drawing.Point(4, 44);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(1116, 435);
            this.tpTable.TabIndex = 1;
            this.tpTable.Text = "Bàn";
            this.tpTable.UseVisualStyleBackColor = true;
            this.tpTable.Enter += new System.EventHandler(this.tpTable_Enter);
            // 
            // gbTableList
            // 
            this.gbTableList.Controls.Add(this.dgvTableList);
            this.gbTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTableList.Location = new System.Drawing.Point(3, 63);
            this.gbTableList.Name = "gbTableList";
            this.gbTableList.Size = new System.Drawing.Size(1110, 369);
            this.gbTableList.TabIndex = 1;
            this.gbTableList.TabStop = false;
            this.gbTableList.Text = "Danh sách bàn";
            // 
            // dgvTableList
            // 
            this.dgvTableList.AllowUserToAddRows = false;
            this.dgvTableList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableList.Location = new System.Drawing.Point(3, 22);
            this.dgvTableList.Name = "dgvTableList";
            this.dgvTableList.RowHeadersVisible = false;
            this.dgvTableList.RowHeadersWidth = 51;
            this.dgvTableList.RowTemplate.Height = 24;
            this.dgvTableList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableList.Size = new System.Drawing.Size(1104, 344);
            this.dgvTableList.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddTable);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveTable);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1110, 60);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddTable
            // 
            this.btnAddTable.BorderThickness = 1;
            this.btnAddTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTable.FillColor = System.Drawing.Color.Transparent;
            this.btnAddTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddTable.ForeColor = System.Drawing.Color.Black;
            this.btnAddTable.Location = new System.Drawing.Point(17, 17);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(7);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(91, 30);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.BorderThickness = 1;
            this.btnRemoveTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveTable.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRemoveTable.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveTable.Location = new System.Drawing.Point(125, 17);
            this.btnRemoveTable.Margin = new System.Windows.Forms.Padding(10, 7, 7, 7);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(91, 30);
            this.btnRemoveTable.TabIndex = 1;
            this.btnRemoveTable.Text = "Xóa";
            this.btnRemoveTable.Click += new System.EventHandler(this.btnRemoveTable_Click);
            // 
            // UC_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcManagement);
            this.Name = "UC_Manage";
            this.Size = new System.Drawing.Size(1124, 483);
            this.Load += new System.EventHandler(this.UC_Manage_Load);
            this.tcManagement.ResumeLayout(false);
            this.tpAccount.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAccountList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountList)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tpTable.ResumeLayout(false);
            this.gbTableList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcManagement;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnAddTable;
        private Guna.UI2.WinForms.Guna2Button btnRemoveTable;
        private System.Windows.Forms.GroupBox gbTableList;
        private System.Windows.Forms.DataGridView dgvTableList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.GroupBox gbAccountList;
        private System.Windows.Forms.DataGridView dgvAccountList;
        private Guna.UI2.WinForms.Guna2Button btnAddAccount;
        private Guna.UI2.WinForms.Guna2Button btnRemoveAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbGender;
        private Guna.UI2.WinForms.Guna2Button btnReloadAccount;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnExport;
    }
}
