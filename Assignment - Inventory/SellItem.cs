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
    public partial class sellitem : Form

       
    {

        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dtbl = new DataTable();
        int product_id;
        public sellitem()
        {
            // Connect Database to store data
            sqlcon.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\DATABASE.MDF;Integrated Security=True;Connect Timeout=30");

            InitializeComponent();
            FillitemComboBox();
            displayData();
        }

        void FillitemComboBox() {

            // Code to get Product nAME
            String constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\DATABASE.MDF;Integrated Security=True;Connect Timeout=30";
            String Query =  "select * from ProductTable ;";
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
                   
                    itemComboBox.Items.Add(pName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        public void displayData()
        {
            // Code to display data on Data Dashboard.
            sqlcon.Open();
            sda = new SqlDataAdapter("Select * from ProductTable", sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataViewSaleItem.DataSource = dtbl;
            sqlcon.Close();
        }


        private void sellButton_Click(object sender, EventArgs e)
        {
            
            int qty = 0;
            string pname = "";
            
            qty = Convert.ToInt32(quanTextbox.Text.Trim().ToString());
            pname = itemComboBox.Items.ToString();
            
            cmd  = new SqlCommand ("update ProductTable set Quantity=Quantity-" + qty + " where Product_Name='" + itemComboBox.SelectedItem.ToString() + "' ", sqlcon);
            sqlcon.Open();
            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Sold", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);

            sqlcon.Close();
            displayData();
        }
        

        public void clearData()
        {
            // Clears input after each sell process is done.
            quanTextbox.Clear();
            

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Gets back to Main Menu panel.
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            sda = new SqlDataAdapter("Select * from ProductTable where Product_Name ='"+ itemComboBox.SelectedItem.ToString()+ "' ", sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            foreach (DataRow dr in dtbl.Rows)
            {
                brandTextbox.Text = dr["Brand"].ToString();
                catTextbox.Text = dr["Category"].ToString();
                custPriceTextbox.Text = dr["Cust_Price"].ToString();
                despTextbox.Text = dr["Desp"].ToString();


            }
            sqlcon.Close();
            displayData();
        }

        private void quanTextbox_TextChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            int qty = 0;

            qty = Convert.ToInt32(quanTextbox.Text.Trim().ToString());
            Convert.ToInt32(custPriceTextbox.Text.Trim().ToString());
            cmd = new SqlCommand("Select * from ProductTable get Cust_Price ='" + custPriceTextbox.Text + "' ", sqlcon);
            cmd = new SqlCommand("Select * from  SaleTable get Item_Price= '" + custPriceTextbox.Text + "' ", sqlcon);
            cmd = new SqlCommand("Select * from  SaleTable set Item_Price= '" + custPriceTextbox.Text + "' ", sqlcon);
            try
            {
                tpriceTextbox.Text = (float.Parse(quanTextbox.Text.Trim()) * float.Parse(custPriceTextbox.Text.Trim())).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //cmd = new SqlCommand("Insert SaleTable TotalPrice='" + tpriceTextbox.Text.Trim() + "' ");
            cmd = new SqlCommand("update SaleTable set Total_Price=" + tpriceTextbox.Text + " ", sqlcon);
            

            sda = new SqlDataAdapter("Select * from SaleTable where qty=" + qty + " ", sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            foreach (DataRow dr in dtbl.Rows)
            {
                
                tpriceTextbox.Text = dr["Total_Price"].ToString();
                



            }
            
            cmd.ExecuteNonQuery();

            
            sqlcon.Close();
            displayData();
            
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string category = "";
            if (itemComboBox.SelectedIndex >= 0)
                category = itemComboBox.Items[itemComboBox.SelectedIndex].ToString();
            
            string c = ("Insert into SaleTable values('" + category + "','" + quanTextbox.Text + "','" + brandTextbox.Text.Trim() + "', '" + catTextbox.Text + "','"+ custPriceTextbox.Text.Trim() + "',  '" + despTextbox.Text.Trim() + "',   '"+ tpriceTextbox.Text.Trim() + "')");
            SqlCommand cmd = new SqlCommand(c, sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data successfully entered into the Database", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlcon.Close();
            displayData();
            
        }

        private void tpriceTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataViewSaleItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Specify the Data view, to show data on Data Dashboard.
            product_id = Convert.ToInt32(dataViewSaleItem.Rows[e.RowIndex].Cells[0].Value.ToString());
            itemComboBox.Text = dataViewSaleItem.Rows[e.RowIndex].Cells[1].Value.ToString();
            quanTextbox.Text = dataViewSaleItem.Rows[e.RowIndex].Cells[2].Value.ToString();
            brandTextbox.Text = dataViewSaleItem.Rows[e.RowIndex].Cells[3].Value.ToString();
            catTextbox.Text = dataViewSaleItem.Rows[e.RowIndex].Cells[4].Value.ToString();
            custPriceTextbox.Text = dataViewSaleItem.Rows[e.RowIndex].Cells[5].Value.ToString();
            despTextbox.Text = dataViewSaleItem.Rows[e.RowIndex].Cells[6].Value.ToString();
            tpriceTextbox.Text = dataViewSaleItem.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void sellitem_Load(object sender, EventArgs e)
        {

        }
    }
}
