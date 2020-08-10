using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from LoginTable Where username = '" + usernameTextbox.Text.Trim() + "' and password = '" + passwordTextbox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                MainMenu objMainMenu = new MainMenu();
                this.Hide();
                objMainMenu.Show();

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
