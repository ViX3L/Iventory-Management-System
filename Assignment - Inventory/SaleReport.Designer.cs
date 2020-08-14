namespace Assignment___Inventory
{
    partial class SaleReport
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
            this.SaleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Assignment___Inventory.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SaleTableTableAdapter = new Assignment___Inventory.DataSet2TableAdapters.SaleTableTableAdapter();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SaleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleTableBindingSource
            // 
            this.SaleTableBindingSource.DataMember = "SaleTable";
            this.SaleTableBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SaleTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Assignment___Inventory.SaleReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SaleTableTableAdapter
            // 
            this.SaleTableTableAdapter.ClearBeforeFill = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(71, 31);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 40);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Go back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(2, 31);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(72, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleReport";
            this.Load += new System.EventHandler(this.SaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SaleTableBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.SaleTableTableAdapter SaleTableTableAdapter;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
    }
}