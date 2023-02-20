namespace Accounting.App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSttings = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoginSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnReportOutcome = new System.Windows.Forms.ToolStripButton();
            this.btnReportIncome = new System.Windows.Forms.ToolStripButton();
            this.btnReportAll = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShowBalance = new System.Windows.Forms.Label();
            this.lblShowOutcome = new System.Windows.Forms.Label();
            this.lblShowIncome = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSttings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuSttings
            // 
            this.menuSttings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSttings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoginSettings});
            this.menuSttings.Image = ((System.Drawing.Image)(resources.GetObject("menuSttings.Image")));
            this.menuSttings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSttings.Name = "menuSttings";
            this.menuSttings.Size = new System.Drawing.Size(63, 22);
            this.menuSttings.Text = "تنظیمات";
            // 
            // btnLoginSettings
            // 
            this.btnLoginSettings.Name = "btnLoginSettings";
            this.btnLoginSettings.Size = new System.Drawing.Size(142, 22);
            this.btnLoginSettings.Text = "تنظیمات ورود";
            this.btnLoginSettings.Click += new System.EventHandler(this.btnLoginSettings_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewTransaction,
            this.btnReportOutcome,
            this.btnReportIncome,
            this.btnReportAll});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 62);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomers
            // 
            this.btnCustomers.AutoSize = false;
            this.btnCustomers.Image = global::Accounting.App.Properties.Resources._customer;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(98, 59);
            this.btnCustomers.Text = "طرف حساب";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.AutoSize = false;
            this.btnNewTransaction.Image = global::Accounting.App.Properties.Resources._pose;
            this.btnNewTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(98, 59);
            this.btnNewTransaction.Text = "تراکنش جدید";
            this.btnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // btnReportOutcome
            // 
            this.btnReportOutcome.AutoSize = false;
            this.btnReportOutcome.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.btnReportOutcome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportOutcome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportOutcome.Name = "btnReportOutcome";
            this.btnReportOutcome.Size = new System.Drawing.Size(98, 59);
            this.btnReportOutcome.Text = "گزارش پرداختی ها";
            this.btnReportOutcome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportOutcome.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReportIncome
            // 
            this.btnReportIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnReportIncome.Image")));
            this.btnReportIncome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportIncome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportIncome.Name = "btnReportIncome";
            this.btnReportIncome.Size = new System.Drawing.Size(98, 59);
            this.btnReportIncome.Text = "گزارش دریافتی ها";
            this.btnReportIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportIncome.Click += new System.EventHandler(this.btnReportIncome_Click);
            // 
            // btnReportAll
            // 
            this.btnReportAll.Image = global::Accounting.App.Properties.Resources._list;
            this.btnReportAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReportAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportAll.Name = "btnReportAll";
            this.btnReportAll.Size = new System.Drawing.Size(65, 59);
            this.btnReportAll.Text = "گزارش کلی";
            this.btnReportAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportAll.Click += new System.EventHandler(this.btnReportAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(118, 17);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 17);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources.appIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblShowBalance);
            this.groupBox1.Controls.Add(this.lblShowOutcome);
            this.groupBox1.Controls.Add(this.lblShowIncome);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblOutcome);
            this.groupBox1.Controls.Add(this.lblIncome);
            this.groupBox1.Location = new System.Drawing.Point(342, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش ماه";
            // 
            // lblShowBalance
            // 
            this.lblShowBalance.Location = new System.Drawing.Point(243, 74);
            this.lblShowBalance.Name = "lblShowBalance";
            this.lblShowBalance.Size = new System.Drawing.Size(138, 23);
            this.lblShowBalance.TabIndex = 5;
            this.lblShowBalance.Text = "0";
            this.lblShowBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblShowOutcome
            // 
            this.lblShowOutcome.Location = new System.Drawing.Point(243, 47);
            this.lblShowOutcome.Name = "lblShowOutcome";
            this.lblShowOutcome.Size = new System.Drawing.Size(138, 23);
            this.lblShowOutcome.TabIndex = 4;
            this.lblShowOutcome.Text = "0";
            this.lblShowOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowIncome
            // 
            this.lblShowIncome.Location = new System.Drawing.Point(243, 21);
            this.lblShowIncome.Name = "lblShowIncome";
            this.lblShowIncome.Size = new System.Drawing.Size(138, 23);
            this.lblShowIncome.TabIndex = 3;
            this.lblShowIncome.Text = "0";
            this.lblShowIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBalance.Location = new System.Drawing.Point(399, 74);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(34, 13);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "مانده:";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(387, 47);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(49, 13);
            this.lblOutcome.TabIndex = 1;
            this.lblOutcome.Text = "پرداختی:";
            this.lblOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(388, 21);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(46, 13);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "دریافتی:";
            this.lblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(192, 110);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه حسابداری شخصی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton menuSttings;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnNewTransaction;
        private System.Windows.Forms.ToolStripButton btnReportOutcome;
        private System.Windows.Forms.ToolStripButton btnReportIncome;
        private System.Windows.Forms.ToolStripButton btnReportAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem btnLoginSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblShowBalance;
        private System.Windows.Forms.Label lblShowOutcome;
        private System.Windows.Forms.Label lblShowIncome;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnRefresh;
    }
}

