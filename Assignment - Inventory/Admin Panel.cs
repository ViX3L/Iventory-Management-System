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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asadu\Documents\GitHub\Assignment---Inventory\Assignment - Inventory\Database\LoginDB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from LoginTable Where username = '" + usernameTextbox.Text.Trim() + "' and password = '" + passwordTextbox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Catalog objCatalog = new Catalog();
                this.Hide();
                objCatalog.Show();

            }
            else
            {
                MessageBox.Show("Access Denied, check username/password and try again!");
            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
