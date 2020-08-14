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
    public partial class TotalInventory : Form
    {
        public TotalInventory()
        {
            InitializeComponent();
        }
        
        
        //initializes new instance 
        SqlConnection sqlcon = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dtbl = new DataTable();
        //declare a variable
        string query;
        int tot = 0;
        int tots = 0;
        private void QuanTotal(string query, DataGridView dtg)
        {
            //opening connection
            sqlcon.Open();
            try
            {
                //initialize a new instance of sqlcommand
                cmd = new SqlCommand();
                //set a connection used by this instance of sqlcommand
                cmd.Connection = sqlcon;
                //set the sql statement to execute at the data source
                cmd.CommandText = query;
                //initialize a new instance of sqlDataAdapter
                sda = new SqlDataAdapter();
                //set the sql statement or stored procedure to execute at the data source
                sda.SelectCommand = cmd;
                //initialize a new instance of DataTable
                dtbl = new DataTable();
                //add or resfresh rows in the certain range in the datatable to match those in the data source.
                sda.Fill(dtbl);
                //set the data source to display the data in the datagridview
                dtg.DataSource = dtbl;


            }
            catch (Exception ex)
            {
                //catching error 
                MessageBox.Show(ex.Message);
            }
            //release all resources used by the component
            sda.Dispose();
            //closing connection
            sqlcon.Close();
        }

        

        
        private void TotalInventory_Load(object sender, EventArgs e)
        {
            //set a connection between SQL server and Visual C#
            sqlcon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASADU\DOCUMENTS\GITHUB\ASSIGNMENT---INVENTORY\ASSIGNMENT - INVENTORY\DATABASE\DATABASE\DATABASE.MDF;Integrated Security=True;Connect Timeout=30";
            //set up a retrieve query
            query = "Select * From ProductTable";
            QuanTotal(query, dataGridView1);//call a load method
        }

        private void calButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //'declaring variable as integer to store the value of the total rows in the datagridview
                int maxrow = dataGridView1.Rows.Count - 1;
                //'getting the values of specific rows
                for (int i = 0; i < maxrow; ++i)
                {
                    //calculate the quantity of all books
                    tot += int.Parse(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString());
                    tots += int.Parse(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells["Supp_Price"].Value.ToString());
                }
                //adding values in the max rows of the dataGridview
                dataGridView1.Rows[maxrow].Cells[3].Value = "Total";
                dataGridView1.Rows[maxrow].Cells[4].Value = tot.ToString();
                dataGridView1.Rows[maxrow].Cells[5].Value = tots.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gobackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
