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
    public partial class AddItem : Form
    {

        SqlConnection sqlcon = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dtbl = new DataTable();

        public AddItem()
        {
            sqlcon.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\DATABASE.MDF;Integrated Security=True;Connect Timeout=30");

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string cat = "";
            if (categoryComboBox.SelectedIndex >= 0)
                cat = categoryComboBox.Items[categoryComboBox.SelectedIndex].ToString();
            sqlcon.Open();
            string c = ("Insert into ProductTable values('" + additemTextbox.Text.Trim() + "','"+cat+"','" + brandTextbox.Text.Trim() + "', '" + qtyTextbox.Text.Trim() + "', '" + spTextbox.Text.Trim() + "', '" + cpTextbox.Text.Trim() + "', '" + despTextbox.Text.Trim() + "')"); 
            SqlCommand cmd = new SqlCommand(c, sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data successfully entered into the Database", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlcon.Close();
            displayData();
        }
        public void displayData() 
        {
            sqlcon.Open();
            sda = new SqlDataAdapter("Select * from ProductTable", sqlcon);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataViewAddItem.DataSource = dtbl;
            sqlcon.Close(); 
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
