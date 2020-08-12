using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment___Inventory
{
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.ProductTable' table. You can move, or remove it, as needed.
            this.ProductTableTableAdapter.Fill(this.DataSet.ProductTable);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.PerformBack();


            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void gobackButton_Click(object sender, EventArgs e)
        {
            //Gets back to Main Menu panel.
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
