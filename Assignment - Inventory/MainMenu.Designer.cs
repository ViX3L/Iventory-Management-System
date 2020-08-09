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
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalStockLabel = new System.Windows.Forms.Label();
            this.totalstockTextbox = new System.Windows.Forms.TextBox();
            this.itemsoldLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.itemcomboBox = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.addToolStripMenuItem.Text = "Edit";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.productToolStripMenuItem.Text = "Add Product";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.updateToolStripMenuItem.Text = "Update Product";
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // totalStockLabel
            // 
            this.totalStockLabel.AutoSize = true;
            this.totalStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockLabel.Location = new System.Drawing.Point(61, 51);
            this.totalStockLabel.Name = "totalStockLabel";
            this.totalStockLabel.Size = new System.Drawing.Size(103, 20);
            this.totalStockLabel.TabIndex = 1;
            this.totalStockLabel.Text = "Total Stock: ";
            this.totalStockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalstockTextbox
            // 
            this.totalstockTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalstockTextbox.Location = new System.Drawing.Point(180, 48);
            this.totalstockTextbox.Name = "totalstockTextbox";
            this.totalstockTextbox.Size = new System.Drawing.Size(127, 27);
            this.totalstockTextbox.TabIndex = 2;
            // 
            // itemsoldLabel
            // 
            this.itemsoldLabel.AutoSize = true;
            this.itemsoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsoldLabel.Location = new System.Drawing.Point(28, 92);
            this.itemsoldLabel.Name = "itemsoldLabel";
            this.itemsoldLabel.Size = new System.Drawing.Size(136, 20);
            this.itemsoldLabel.TabIndex = 3;
            this.itemsoldLabel.Text = "No. of Item sold: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(180, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 27);
            this.textBox1.TabIndex = 4;
            // 
            // itemcomboBox
            // 
            this.itemcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemcomboBox.FormattingEnabled = true;
            this.itemcomboBox.Items.AddRange(new object[] {
            "Gaming Gear",
            "System & Accessories",
            "PC Hardware"});
            this.itemcomboBox.Location = new System.Drawing.Point(180, 134);
            this.itemcomboBox.Name = "itemcomboBox";
            this.itemcomboBox.Size = new System.Drawing.Size(259, 28);
            this.itemcomboBox.TabIndex = 5;
            this.itemcomboBox.Tag = "select";
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(13, 137);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(146, 20);
            this.selectLabel.TabIndex = 6;
            this.selectLabel.Text = "Choose Periphals:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.itemcomboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.itemsoldLabel);
            this.Controls.Add(this.totalstockTextbox);
            this.Controls.Add(this.totalStockLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.Label totalStockLabel;
        private System.Windows.Forms.TextBox totalstockTextbox;
        private System.Windows.Forms.Label itemsoldLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox itemcomboBox;
        private System.Windows.Forms.Label selectLabel;
    }
}