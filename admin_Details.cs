﻿using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodness_Pharmacy
{
    public partial class admin_Details : Form
    {
        public admin_Details()
        {
            InitializeComponent();
            linkLabel2.Text = Program.UserRole + " - Sign Out";
            bunifuLabel3.Text = Program.UserName;
        }

        private void bunifuButton218_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void bunifuButton217_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Close();
        }

        private void bunifuButton216_Click(object sender, EventArgs e)
        {
            if (Program.UserRole == "Admin")
            {
                Sales_Report salesrep = new Sales_Report();
                salesrep.Show();
                this.Close();
            }
            else
                MessageBox.Show("You do not have permission to access this");
        }

        private void bunifuButton215_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void bunifuButton214_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
            this.Close();
        }

        private void bunifuButton213_Click(object sender, EventArgs e)
        {
            Purchase purch = new Purchase();
            purch.Show();
            this.Close();
        }

        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Close();
        }

        private void bunifuButton211_Click(object sender, EventArgs e)
        {
            Technical_Support tech = new Technical_Support();
            tech.Show();
            this.Close();
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will close the application. Do you wish to proceed?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Login_and_Signup logsign = new Login_and_Signup();
                logsign.Show();
                this.Hide();

            }
        }

        private void admin_Details_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Goodness_Pharmacy\\Goodness_pharm.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    // Create the SQL select query
                    string query = "SELECT * FROM adminsignup";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a DataTable to store the retrieved data
                        DataTable dataTable = new DataTable();

                        // Open the connection
                        connection.Open();

                        // Create a SqlDataAdapter to execute the query and fill the DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);

                        // Set the DataTable as the DataSource for the DataGridView
                        bunifuDataGridView1.DataSource = dataTable;
                    }
                }
                catch (SqlException ex)
                {
                    // Handle SQL exception
                    MessageBox.Show("An SQL exception occurred: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    MessageBox.Show("An exception occurred: " + ex.Message);
                }
            }
        }
        private int currentIndex = 0;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
          
            if (currentIndex < bunifuDataGridView1.Rows.Count - 1)
            {
                // Increment the current index to move to the next record
                currentIndex++;

                // Display the data of the next record in the DataGridView
                bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[currentIndex].Cells[0];
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                // Decrement the current index to move to the previous record
                currentIndex--;

                // Display the data of the previous record in the DataGridView
                bunifuDataGridView1.CurrentCell = bunifuDataGridView1.Rows[currentIndex].Cells[0];
            }
        }

       
    }
}
