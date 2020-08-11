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
    public partial class PurchaseReport : Form
    {
        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.ProductTable' table. You can move, or remove it, as needed.
            this.ProductTableTableAdapter.Fill(this.DataSet.ProductTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
