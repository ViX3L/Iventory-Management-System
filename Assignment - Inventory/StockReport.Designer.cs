namespace Assignment___Inventory
{
    partial class StockReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Assignment___Inventory.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductTableTableAdapter = new Assignment___Inventory.DataSet1TableAdapters.ProductTableTableAdapter();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductTableBindingSource
            // 
            this.ProductTableBindingSource.DataMember = "ProductTable";
            this.ProductTableBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Assignment___Inventory.StockReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProductTableTableAdapter
            // 
            this.ProductTableTableAdapter.ClearBeforeFill = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(0, 29);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(72, 40);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(69, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 40);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Go back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockReport";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductTableBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ProductTableTableAdapter ProductTableTableAdapter;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
    }
}