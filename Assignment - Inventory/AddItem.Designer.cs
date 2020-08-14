namespace Assignment___Inventory
{
    partial class AddItem
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
            this.additemLabel = new System.Windows.Forms.Label();
            this.additemTextbox = new System.Windows.Forms.TextBox();
            this.brandTextbox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyTextbox = new System.Windows.Forms.TextBox();
            this.spTextbox = new System.Windows.Forms.TextBox();
            this.spLabel = new System.Windows.Forms.Label();
            this.cpTextbox = new System.Windows.Forms.TextBox();
            this.cpLabel = new System.Windows.Forms.Label();
            this.despTextbox = new System.Windows.Forms.TextBox();
            this.despLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dataViewAddItem = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // additemLabel
            // 
            this.additemLabel.AutoSize = true;
            this.additemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemLabel.Location = new System.Drawing.Point(38, 32);
            this.additemLabel.Name = "additemLabel";
            this.additemLabel.Size = new System.Drawing.Size(134, 20);
            this.additemLabel.TabIndex = 0;
            this.additemLabel.Text = "Product Name:";
            // 
            // additemTextbox
            // 
            this.additemTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemTextbox.Location = new System.Drawing.Point(241, 28);
            this.additemTextbox.Name = "additemTextbox";
            this.additemTextbox.Size = new System.Drawing.Size(381, 27);
            this.additemTextbox.TabIndex = 1;
            // 
            // brandTextbox
            // 
            this.brandTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextbox.Location = new System.Drawing.Point(877, 86);
            this.brandTextbox.Name = "brandTextbox";
            this.brandTextbox.Size = new System.Drawing.Size(381, 27);
            this.brandTextbox.TabIndex = 3;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(672, 88);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(71, 20);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Brand: ";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(38, 88);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(85, 20);
            this.qtyLabel.TabIndex = 4;
            this.qtyLabel.Text = "Quantity:";
            // 
            // qtyTextbox
            // 
            this.qtyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextbox.Location = new System.Drawing.Point(241, 86);
            this.qtyTextbox.Name = "qtyTextbox";
            this.qtyTextbox.Size = new System.Drawing.Size(381, 27);
            this.qtyTextbox.TabIndex = 5;
            this.qtyTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // spTextbox
            // 
            this.spTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spTextbox.Location = new System.Drawing.Point(877, 135);
            this.spTextbox.Name = "spTextbox";
            this.spTextbox.Size = new System.Drawing.Size(381, 27);
            this.spTextbox.TabIndex = 7;
            // 
            // spLabel
            // 
            this.spLabel.AutoSize = true;
            this.spLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spLabel.Location = new System.Drawing.Point(672, 138);
            this.spLabel.Name = "spLabel";
            this.spLabel.Size = new System.Drawing.Size(134, 20);
            this.spLabel.TabIndex = 6;
            this.spLabel.Text = "Supplier Price:";
            // 
            // cpTextbox
            // 
            this.cpTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpTextbox.Location = new System.Drawing.Point(241, 138);
            this.cpTextbox.Name = "cpTextbox";
            this.cpTextbox.Size = new System.Drawing.Size(381, 27);
            this.cpTextbox.TabIndex = 9;
            // 
            // cpLabel
            // 
            this.cpLabel.AutoSize = true;
            this.cpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpLabel.Location = new System.Drawing.Point(38, 142);
            this.cpLabel.Name = "cpLabel";
            this.cpLabel.Size = new System.Drawing.Size(146, 20);
            this.cpLabel.TabIndex = 8;
            this.cpLabel.Text = "Customer Price:";
            // 
            // despTextbox
            // 
            this.despTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despTextbox.Location = new System.Drawing.Point(1452, 33);
            this.despTextbox.Multiline = true;
            this.despTextbox.Name = "despTextbox";
            this.despTextbox.Size = new System.Drawing.Size(265, 112);
            this.despTextbox.TabIndex = 11;
            // 
            // despLabel
            // 
            this.despLabel.AutoSize = true;
            this.despLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despLabel.Location = new System.Drawing.Point(1321, 32);
            this.despLabel.Name = "despLabel";
            this.despLabel.Size = new System.Drawing.Size(112, 20);
            this.despLabel.TabIndex = 10;
            this.despLabel.Text = "Description:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(529, 608);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 52);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataViewAddItem
            // 
            this.dataViewAddItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewAddItem.Location = new System.Drawing.Point(21, 214);
            this.dataViewAddItem.Name = "dataViewAddItem";
            this.dataViewAddItem.RowHeadersWidth = 51;
            this.dataViewAddItem.RowTemplate.Height = 24;
            this.dataViewAddItem.Size = new System.Drawing.Size(1683, 333);
            this.dataViewAddItem.TabIndex = 13;
            this.dataViewAddItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewAddItem_CellContentClick);
            this.dataViewAddItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewAddItem_CellDoubleClick);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1178, 608);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(124, 52);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(672, 36);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(96, 20);
            this.categoryLabel.TabIndex = 15;
            this.categoryLabel.Text = "Category: ";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Controller",
            "Ethernet Adapter",
            "Headphone",
            "Keyboard",
            "Mouse",
            "Mouse Mat"});
            this.categoryComboBox.Location = new System.Drawing.Point(877, 33);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(381, 28);
            this.categoryComboBox.TabIndex = 16;
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(743, 608);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(124, 52);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // delButton
            // 
            this.delButton.AutoSize = true;
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(963, 608);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(124, 52);
            this.delButton.TabIndex = 18;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1749, 695);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataViewAddItem);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.despTextbox);
            this.Controls.Add(this.despLabel);
            this.Controls.Add(this.cpTextbox);
            this.Controls.Add(this.cpLabel);
            this.Controls.Add(this.spTextbox);
            this.Controls.Add(this.spLabel);
            this.Controls.Add(this.qtyTextbox);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.brandTextbox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.additemTextbox);
            this.Controls.Add(this.additemLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update / Delete Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAddItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label additemLabel;
        private System.Windows.Forms.TextBox additemTextbox;
        private System.Windows.Forms.TextBox brandTextbox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.TextBox qtyTextbox;
        private System.Windows.Forms.TextBox spTextbox;
        private System.Windows.Forms.Label spLabel;
        private System.Windows.Forms.TextBox cpTextbox;
        private System.Windows.Forms.Label cpLabel;
        private System.Windows.Forms.TextBox despTextbox;
        private System.Windows.Forms.Label despLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataViewAddItem;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button delButton;
    }
}