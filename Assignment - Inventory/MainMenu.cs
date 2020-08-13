using System.Windows.Forms;

namespace Assignment___Inventory
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AddItem addProduct = new AddItem();
            addProduct.Show();
            this.Hide();
        }

        private void purchaseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
            InventoryReport inv = new InventoryReport();
            inv.Show();
            this.Hide();
            

        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void sellItemToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            sellitem sell = new sellitem();
            sell.Show();
            this.Hide();

        }

        private void totalstockTextbox_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
