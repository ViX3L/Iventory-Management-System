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
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ProductTable' table. You can move, or remove it, as needed.
            this.ProductTableTableAdapter.Fill(this.DataSet1.ProductTable);

            this.reportViewer1.RefreshReport();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
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
