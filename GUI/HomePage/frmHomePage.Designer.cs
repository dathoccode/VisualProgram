namespace ABCCoffee.GUI.HomePage
{
    partial class frmHomePage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrderInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccountInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnManage = new Guna.UI2.WinForms.Guna2Button();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.flowLayoutPanel1.Controls.Add(this.btnOrderInfo);
            this.flowLayoutPanel1.Controls.Add(this.btnAccountInfo);
            this.flowLayoutPanel1.Controls.Add(this.btnManage);
            this.flowLayoutPanel1.Controls.Add(this.btnStatistic);
            this.flowLayoutPanel1.Controls.Add(this.btnCheckIn);
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1124, 93);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnOrderInfo
            // 
            this.btnOrderInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderInfo.CustomImages.Image = global::ABCCoffee.Properties.Resources.icon_order;
            this.btnOrderInfo.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnOrderInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrderInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrderInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderInfo.FillColor = System.Drawing.Color.White;
            this.btnOrderInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrderInfo.ForeColor = System.Drawing.Color.Black;
            this.btnOrderInfo.Location = new System.Drawing.Point(17, 13);
            this.btnOrderInfo.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnOrderInfo.Name = "btnOrderInfo";
            this.btnOrderInfo.Size = new System.Drawing.Size(145, 62);
            this.btnOrderInfo.TabIndex = 0;
            this.btnOrderInfo.Text = "Đặt hàng";
            this.btnOrderInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrderInfo.Click += new System.EventHandler(this.btnOrderInfo_Click);
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnAccountInfo.CustomImages.Image = global::ABCCoffee.Properties.Resources.icon_account;
            this.btnAccountInfo.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAccountInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccountInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccountInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccountInfo.FillColor = System.Drawing.Color.White;
            this.btnAccountInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAccountInfo.ForeColor = System.Drawing.Color.Black;
            this.btnAccountInfo.Location = new System.Drawing.Point(176, 13);
            this.btnAccountInfo.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.Size = new System.Drawing.Size(129, 62);
            this.btnAccountInfo.TabIndex = 1;
            this.btnAccountInfo.Text = "Tài khoản";
            this.btnAccountInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccountInfo.Click += new System.EventHandler(this.btnAccountInfo_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.Transparent;
            this.btnManage.CustomImages.Image = global::ABCCoffee.Properties.Resources.icon_order;
            this.btnManage.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManage.FillColor = System.Drawing.Color.White;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManage.ForeColor = System.Drawing.Color.Black;
            this.btnManage.Location = new System.Drawing.Point(319, 13);
            this.btnManage.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(129, 62);
            this.btnManage.TabIndex = 2;
            this.btnManage.Text = "Quản lý";
            this.btnManage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistic.CustomImages.Image = global::ABCCoffee.Properties.Resources.icon_order;
            this.btnStatistic.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStatistic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistic.FillColor = System.Drawing.Color.White;
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatistic.ForeColor = System.Drawing.Color.Black;
            this.btnStatistic.Location = new System.Drawing.Point(462, 13);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(129, 62);
            this.btnStatistic.TabIndex = 3;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CustomImages.Image = global::ABCCoffee.Properties.Resources.icon_order;
            this.btnExit.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(760, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 62);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 93);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1124, 483);
            this.pnMain.TabIndex = 1;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.CustomImages.Image = global::ABCCoffee.Properties.Resources.icon_checkin;
            this.btnCheckIn.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckIn.FillColor = System.Drawing.Color.White;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckIn.ForeColor = System.Drawing.Color.Black;
            this.btnCheckIn.Location = new System.Drawing.Point(605, 13);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(141, 62);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Chấm công";
            this.btnCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1124, 576);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHomePage";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnOrderInfo;
        private System.Windows.Forms.Panel pnMain;
        private Guna.UI2.WinForms.Guna2Button btnAccountInfo;
        private Guna.UI2.WinForms.Guna2Button btnManage;
        private Guna.UI2.WinForms.Guna2Button btnStatistic;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnCheckIn;
    }
}