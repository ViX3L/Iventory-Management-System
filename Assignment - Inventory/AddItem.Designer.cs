﻿namespace Assignment___Inventory
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
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // additemLabel
            // 
            this.additemLabel.AutoSize = true;
            this.additemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemLabel.Location = new System.Drawing.Point(30, 28);
            this.additemLabel.Name = "additemLabel";
            this.additemLabel.Size = new System.Drawing.Size(121, 20);
            this.additemLabel.TabIndex = 0;
            this.additemLabel.Text = "Product Name:";
            // 
            // additemTextbox
            // 
            this.additemTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemTextbox.Location = new System.Drawing.Point(193, 25);
            this.additemTextbox.Name = "additemTextbox";
            this.additemTextbox.Size = new System.Drawing.Size(305, 27);
            this.additemTextbox.TabIndex = 1;
            // 
            // brandTextbox
            // 
            this.brandTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextbox.Location = new System.Drawing.Point(193, 111);
            this.brandTextbox.Name = "brandTextbox";
            this.brandTextbox.Size = new System.Drawing.Size(305, 27);
            this.brandTextbox.TabIndex = 3;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(30, 114);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(64, 20);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Brand: ";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(30, 158);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(76, 20);
            this.qtyLabel.TabIndex = 4;
            this.qtyLabel.Text = "Quantity:";
            // 
            // qtyTextbox
            // 
            this.qtyTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextbox.Location = new System.Drawing.Point(193, 155);
            this.qtyTextbox.Name = "qtyTextbox";
            this.qtyTextbox.Size = new System.Drawing.Size(305, 27);
            this.qtyTextbox.TabIndex = 5;
            this.qtyTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // spTextbox
            // 
            this.spTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spTextbox.Location = new System.Drawing.Point(193, 200);
            this.spTextbox.Name = "spTextbox";
            this.spTextbox.Size = new System.Drawing.Size(305, 27);
            this.spTextbox.TabIndex = 7;
            // 
            // spLabel
            // 
            this.spLabel.AutoSize = true;
            this.spLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spLabel.Location = new System.Drawing.Point(30, 203);
            this.spLabel.Name = "spLabel";
            this.spLabel.Size = new System.Drawing.Size(119, 20);
            this.spLabel.TabIndex = 6;
            this.spLabel.Text = "Supplier Price:";
            // 
            // cpTextbox
            // 
            this.cpTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpTextbox.Location = new System.Drawing.Point(193, 244);
            this.cpTextbox.Name = "cpTextbox";
            this.cpTextbox.Size = new System.Drawing.Size(305, 27);
            this.cpTextbox.TabIndex = 9;
            // 
            // cpLabel
            // 
            this.cpLabel.AutoSize = true;
            this.cpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpLabel.Location = new System.Drawing.Point(30, 247);
            this.cpLabel.Name = "cpLabel";
            this.cpLabel.Size = new System.Drawing.Size(131, 20);
            this.cpLabel.TabIndex = 8;
            this.cpLabel.Text = "Customer Price:";
            // 
            // despTextbox
            // 
            this.despTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despTextbox.Location = new System.Drawing.Point(193, 289);
            this.despTextbox.Multiline = true;
            this.despTextbox.Name = "despTextbox";
            this.despTextbox.Size = new System.Drawing.Size(305, 150);
            this.despTextbox.TabIndex = 11;
            // 
            // despLabel
            // 
            this.despLabel.AutoSize = true;
            this.despLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despLabel.Location = new System.Drawing.Point(30, 289);
            this.despLabel.Name = "despLabel";
            this.despLabel.Size = new System.Drawing.Size(100, 20);
            this.despLabel.TabIndex = 10;
            this.despLabel.Text = "Description:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(193, 470);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 46);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataViewAddItem
            // 
            this.dataViewAddItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewAddItem.Location = new System.Drawing.Point(550, 25);
            this.dataViewAddItem.Name = "dataViewAddItem";
            this.dataViewAddItem.RowHeadersWidth = 51;
            this.dataViewAddItem.RowTemplate.Height = 24;
            this.dataViewAddItem.Size = new System.Drawing.Size(631, 462);
            this.dataViewAddItem.TabIndex = 13;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(398, 470);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 46);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(30, 70);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(86, 20);
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
            this.categoryComboBox.Location = new System.Drawing.Point(193, 67);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(305, 28);
            this.categoryComboBox.TabIndex = 16;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 582);
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
            this.MaximizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
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
    }
}