namespace Assignment___Inventory
{
    partial class sellitem
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
            this.itemSelectLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.quanTextbox = new System.Windows.Forms.TextBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.brandTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.catTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.custPriceTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.despTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tpriceTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataViewSaleItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSaleItem)).BeginInit();
            this.SuspendLayout();
            // 
            // itemSelectLabel
            // 
            this.itemSelectLabel.AutoSize = true;
            this.itemSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSelectLabel.Location = new System.Drawing.Point(33, 39);
            this.itemSelectLabel.Name = "itemSelectLabel";
            this.itemSelectLabel.Size = new System.Drawing.Size(145, 20);
            this.itemSelectLabel.TabIndex = 0;
            this.itemSelectLabel.Text = "Select Product: ";
            // 
            // itemComboBox
            // 
            this.itemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(236, 36);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(275, 28);
            this.itemComboBox.TabIndex = 1;
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(33, 85);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(91, 20);
            this.qtyLabel.TabIndex = 2;
            this.qtyLabel.Text = "Quantity: ";
            // 
            // quanTextbox
            // 
            this.quanTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanTextbox.Location = new System.Drawing.Point(236, 82);
            this.quanTextbox.Name = "quanTextbox";
            this.quanTextbox.Size = new System.Drawing.Size(275, 27);
            this.quanTextbox.TabIndex = 3;
            this.quanTextbox.TextChanged += new System.EventHandler(this.quanTextbox_TextChanged);
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(484, 479);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(104, 46);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(352, 479);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 46);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // brandTextbox
            // 
            this.brandTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextbox.Location = new System.Drawing.Point(751, 36);
            this.brandTextbox.Name = "brandTextbox";
            this.brandTextbox.Size = new System.Drawing.Size(275, 27);
            this.brandTextbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Brand: ";
            // 
            // catTextbox
            // 
            this.catTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTextbox.Location = new System.Drawing.Point(751, 82);
            this.catTextbox.Name = "catTextbox";
            this.catTextbox.Size = new System.Drawing.Size(275, 27);
            this.catTextbox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Category: ";
            // 
            // custPriceTextbox
            // 
            this.custPriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPriceTextbox.Location = new System.Drawing.Point(236, 129);
            this.custPriceTextbox.Name = "custPriceTextbox";
            this.custPriceTextbox.Size = new System.Drawing.Size(275, 27);
            this.custPriceTextbox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Price Per Unit: ";
            // 
            // despTextbox
            // 
            this.despTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despTextbox.Location = new System.Drawing.Point(751, 132);
            this.despTextbox.Name = "despTextbox";
            this.despTextbox.Size = new System.Drawing.Size(275, 27);
            this.despTextbox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Description: ";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(620, 480);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 46);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tpriceTextbox
            // 
            this.tpriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpriceTextbox.Location = new System.Drawing.Point(236, 177);
            this.tpriceTextbox.Name = "tpriceTextbox";
            this.tpriceTextbox.Size = new System.Drawing.Size(275, 27);
            this.tpriceTextbox.TabIndex = 28;
            this.tpriceTextbox.TextChanged += new System.EventHandler(this.tpriceTextbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total Price: ";
            // 
            // dataViewSaleItem
            // 
            this.dataViewSaleItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewSaleItem.Location = new System.Drawing.Point(24, 223);
            this.dataViewSaleItem.Name = "dataViewSaleItem";
            this.dataViewSaleItem.RowHeadersWidth = 51;
            this.dataViewSaleItem.RowTemplate.Height = 24;
            this.dataViewSaleItem.Size = new System.Drawing.Size(1002, 226);
            this.dataViewSaleItem.TabIndex = 29;
            this.dataViewSaleItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewSaleItem_CellContentClick);
            // 
            // sellitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1053, 552);
            this.Controls.Add(this.dataViewSaleItem);
            this.Controls.Add(this.tpriceTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.despTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.custPriceTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.catTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brandTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.quanTextbox);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.itemSelectLabel);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MaximizeBox = false;
            this.Name = "sellitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Item";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewSaleItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemSelectLabel;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.TextBox quanTextbox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox brandTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox catTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custPriceTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox despTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox tpriceTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataViewSaleItem;
    }
}