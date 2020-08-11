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

        public sellitem()
        {
            // Connect Database to store data
            sqlcon.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\DATABASE.MDF;Integrated Security=True;Connect Timeout=30");

            InitializeComponent();
            FillitemComboBox();
            
        }

        void FillitemComboBox() {

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
            sqlcon.Close();
        }


        private void sellButton_Click(object sender, EventArgs e)
        {
            int qty = 0;
            string pname = "";
            
            qty = Convert.ToInt32(quanTextbox.Text.Trim().ToString());
            pname = itemComboBox.Items.ToString();
            
            cmd  = new SqlCommand ("update ProductTable set Quantity=Quantity-" + qty + " ", sqlcon);
            sqlcon.Open();
            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Sold", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlcon.Close();




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
    }
}
