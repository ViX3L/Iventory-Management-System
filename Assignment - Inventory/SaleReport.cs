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
    public partial class SaleReport : Form
    {
        public SaleReport()
        {
            InitializeComponent();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.SaleTable' table. You can move, or remove it, as needed.
            this.SaleTableTableAdapter.Fill(this.DataSet2.SaleTable);

            this.reportViewer1.RefreshReport();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
