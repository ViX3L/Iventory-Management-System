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
            this.SuspendLayout();
            // 
            // itemSelectLabel
            // 
            this.itemSelectLabel.AutoSize = true;
            this.itemSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSelectLabel.Location = new System.Drawing.Point(38, 39);
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
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(38, 85);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(150, 20);
            this.qtyLabel.TabIndex = 2;
            this.qtyLabel.Text = "Select Quantity: ";
            // 
            // quanTextbox
            // 
            this.quanTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanTextbox.Location = new System.Drawing.Point(236, 82);
            this.quanTextbox.Name = "quanTextbox";
            this.quanTextbox.Size = new System.Drawing.Size(275, 27);
            this.quanTextbox.TabIndex = 3;
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(137, 175);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(99, 43);
            this.sellButton.TabIndex = 4;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(310, 173);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 46);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sellitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(565, 250);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.quanTextbox);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.itemSelectLabel);
            this.Name = "sellitem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Item";
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
    }
}