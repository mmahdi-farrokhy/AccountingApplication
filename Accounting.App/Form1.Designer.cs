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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuSttings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewTransaction = new System.Windows.Forms.ToolStripButton();
            this.btnReportOutcome = new System.Windows.Forms.ToolStripButton();
            this.btnReportIncome = new System.Windows.Forms.ToolStripButton();
            this.btnReportAll = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.menuSttings.Image = ((System.Drawing.Image)(resources.GetObject("menuSttings.Image")));
            this.menuSttings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSttings.Name = "menuSttings";
            this.menuSttings.Size = new System.Drawing.Size(63, 22);
            this.menuSttings.Text = "تنظیمات";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه حسابداری شخصی";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
    }
}

