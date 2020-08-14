namespace Assignment___Inventory
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.stockTextbox = new System.Windows.Forms.TextBox();
            this.stocktotalCombox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tioneGroupBox1 = new System.Windows.Forms.GroupBox();
            this.totalStockLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tioneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.sellItemToolStripMenuItem});
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.addToolStripMenuItem.Text = "Options";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productToolStripMenuItem.Text = "Add Item";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // sellItemToolStripMenuItem
            // 
            this.sellItemToolStripMenuItem.Name = "sellItemToolStripMenuItem";
            this.sellItemToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sellItemToolStripMenuItem.Text = "Sell Item";
            this.sellItemToolStripMenuItem.Click += new System.EventHandler(this.sellItemToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.saleReportToolStripMenuItem,
            this.totalQuantityToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.purchaseToolStripMenuItem.Text = "Stock Report";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // saleReportToolStripMenuItem
            // 
            this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
            this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saleReportToolStripMenuItem.Text = "Sale Report";
            this.saleReportToolStripMenuItem.Click += new System.EventHandler(this.saleReportToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.logoutToolStripMenuItem.Text = "Sign Out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.SignOutToolStripMenuItem_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(198, 158);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 45);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.headerLabel.Location = new System.Drawing.Point(94, 92);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(678, 44);
            this.headerLabel.TabIndex = 6;
            this.headerLabel.Text = "InfoSYS Inventory Management System";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // stockTextbox
            // 
            this.stockTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTextbox.Location = new System.Drawing.Point(207, 102);
            this.stockTextbox.Name = "stockTextbox";
            this.stockTextbox.Size = new System.Drawing.Size(247, 27);
            this.stockTextbox.TabIndex = 8;
            this.stockTextbox.TextChanged += new System.EventHandler(this.totalStock_TextChanged);
            // 
            // stocktotalCombox
            // 
            this.stocktotalCombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktotalCombox.FormattingEnabled = true;
            this.stocktotalCombox.Location = new System.Drawing.Point(207, 49);
            this.stocktotalCombox.Name = "stocktotalCombox";
            this.stocktotalCombox.Size = new System.Drawing.Size(247, 28);
            this.stocktotalCombox.TabIndex = 10;
            this.stocktotalCombox.SelectedIndexChanged += new System.EventHandler(this.stocktotalCombox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(313, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome to";
            // 
            // tioneGroupBox1
            // 
            this.tioneGroupBox1.Controls.Add(this.label1);
            this.tioneGroupBox1.Controls.Add(this.totalStockLabel);
            this.tioneGroupBox1.Controls.Add(this.stocktotalCombox);
            this.tioneGroupBox1.Controls.Add(this.exitButton);
            this.tioneGroupBox1.Controls.Add(this.stockTextbox);
            this.tioneGroupBox1.Location = new System.Drawing.Point(182, 166);
            this.tioneGroupBox1.Name = "tioneGroupBox1";
            this.tioneGroupBox1.Size = new System.Drawing.Size(500, 228);
            this.tioneGroupBox1.TabIndex = 12;
            this.tioneGroupBox1.TabStop = false;
            // 
            // totalStockLabel
            // 
            this.totalStockLabel.AutoSize = true;
            this.totalStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockLabel.Location = new System.Drawing.Point(53, 105);
            this.totalStockLabel.Name = "totalStockLabel";
            this.totalStockLabel.Size = new System.Drawing.Size(89, 20);
            this.totalStockLabel.TabIndex = 7;
            this.totalStockLabel.Text = "In Stock: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Item: ";
            // 
            // totalQuantityToolStripMenuItem
            // 
            this.totalQuantityToolStripMenuItem.Name = "totalQuantityToolStripMenuItem";
            this.totalQuantityToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.totalQuantityToolStripMenuItem.Text = "Total Quantity";
            this.totalQuantityToolStripMenuItem.Click += new System.EventHandler(this.totalQuantityToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(873, 457);
            this.Controls.Add(this.tioneGroupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Panel";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tioneGroupBox1.ResumeLayout(false);
            this.tioneGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem sellItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox stockTextbox;
        private System.Windows.Forms.ComboBox stocktotalCombox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox tioneGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalStockLabel;
        private System.Windows.Forms.ToolStripMenuItem totalQuantityToolStripMenuItem;
    }
}