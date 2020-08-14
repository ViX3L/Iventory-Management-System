namespace Assignment___Inventory
{
    partial class TotalInventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gobackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // calButton
            // 
            this.calButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calButton.Location = new System.Drawing.Point(154, 296);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(117, 45);
            this.calButton.TabIndex = 1;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(295, 296);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 45);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gobackButton
            // 
            this.gobackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackButton.Location = new System.Drawing.Point(439, 296);
            this.gobackButton.Name = "gobackButton";
            this.gobackButton.Size = new System.Drawing.Size(117, 45);
            this.gobackButton.TabIndex = 3;
            this.gobackButton.Text = "Go Back";
            this.gobackButton.UseVisualStyleBackColor = true;
            this.gobackButton.Click += new System.EventHandler(this.gobackButton_Click);
            // 
            // TotalInventory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(765, 380);
            this.Controls.Add(this.gobackButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "TotalInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Quantity";
            this.Load += new System.EventHandler(this.TotalInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button gobackButton;
    }
}