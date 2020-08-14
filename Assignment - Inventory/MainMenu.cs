using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Assignment___Inventory
{
    public partial class MainMenu : Form
    {
        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dtbl = new DataTable();
        public MainMenu()
        {
            sqlcon.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\DATABASE.MDF;Integrated Security=True;Connect Timeout=30");

            InitializeComponent();
            FillitemComboBox();
            
        }
        void FillitemComboBox()
        {

            // Code to get Product nAME
            String constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\DATABASE.MDF;Integrated Security=True;Connect Timeout=30";
            String Query = "select * from ProductTable ;";
            SqlConnection sqlcon = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, sqlcon);
            SqlDataReader myReader;
            try
            {
                sqlcon.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string pName = myReader.GetString(1);

                    stocktotalCombox.Items.Add(pName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            this.Hide();
            StockReport sr = new StockReport();
            sr.Show();
           
            

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

        private void saleReportToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            SaleReport sr = new SaleReport();
            sr.Show();
        }

        private void SignOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            adminForm af = new adminForm();
            af.Show();
        }

        private void MainMenu_Load(object sender, System.EventArgs e)
        {
           
        }

        private void headerLabel_Click(object sender, System.EventArgs e)
        {

        }

        private void totalStock_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void stocktotalCombox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            sqlcon.Open();
            sda = new SqlDataAdapter("Select * from ProductTable where Product_Name ='" + stocktotalCombox.SelectedItem.ToString() + "' ", sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            foreach (DataRow dr in dtbl.Rows)
            {
                stockTextbox.Text = dr["Quantity"].ToString();
                


            }
            sqlcon.Close();
        }

        private void totalQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalInventory ti = new TotalInventory();
            ti.Show();
        }
    }
}
