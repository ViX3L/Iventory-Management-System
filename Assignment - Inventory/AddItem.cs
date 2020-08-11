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
        int product_id;

        public AddItem()
        {
            sqlcon.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\DATABASE.MDF;Integrated Security=True;Connect Timeout=30");

            InitializeComponent();
            displayData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string category = "";
            if (categoryComboBox.SelectedIndex >= 0)
                category = categoryComboBox.Items[categoryComboBox.SelectedIndex].ToString();
            sqlcon.Open();
            string c = ("Insert into ProductTable values('" + additemTextbox.Text.Trim() + "','"+category+"','" + brandTextbox.Text.Trim() + "', '" + qtyTextbox.Text.Trim() + "', '" + spTextbox.Text.Trim() + "', '" + cpTextbox.Text.Trim() + "', '" + despTextbox.Text.Trim() + "')"); 
            SqlCommand cmd = new SqlCommand(c, sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data successfully entered into the Database", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlcon.Close();
            clearData();

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

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void dataViewAddItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            product_id = Convert.ToInt32(dataViewAddItem.Rows[e.RowIndex].Cells[0].Value.ToString());
            additemTextbox.Text = dataViewAddItem.Rows[e.RowIndex].Cells[1].Value.ToString();
            categoryComboBox.Text = dataViewAddItem.Rows[e.RowIndex].Cells[2].Value.ToString();
            brandTextbox.Text = dataViewAddItem.Rows[e.RowIndex].Cells[3].Value.ToString();
            qtyTextbox.Text = dataViewAddItem.Rows[e.RowIndex].Cells[4].Value.ToString();
            spTextbox.Text = dataViewAddItem.Rows[e.RowIndex].Cells[5].Value.ToString();
            cpTextbox.Text = dataViewAddItem.Rows[e.RowIndex].Cells[6].Value.ToString();
            despTextbox.Text = dataViewAddItem.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
         
                
                cmd = new SqlCommand("update ProductTable set Product_Name='" + additemTextbox.Text + "', Category='" + categoryComboBox.Text + "', Brand='" + brandTextbox.Text + "', Quantity='" + qtyTextbox.Text + "', Supplier_Price='" + spTextbox.Text + "', Cust_Price='" + cpTextbox.Text + "', Description='" + despTextbox.Text + "'where Product_ID='"+product_id+"' ", sqlcon);
                sqlcon.Open();
                
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Information Updated in Database!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlcon.Close();
                
                displayData();
                clearData();
            

        }

        private void delButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            cmd = new SqlCommand("delete from ProductTable where Product_ID='" + product_id + "'", sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information Deleted");

            sqlcon.Close();
            clearData();
            displayData();  

        }
        public void clearData()
        {
            additemTextbox.Clear();
            brandTextbox.Clear();
            qtyTextbox.Clear();
            spTextbox.Clear();
            cpTextbox.Clear();
            despTextbox.Clear(); 

        }

        

       
    }
}
