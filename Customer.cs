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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            linkLabel1.Text = Program.UserRole + " - Sign Out";
            bunifuLabel2.Text = Program.UserName;
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {
            Manage_Customers manage = new Manage_Customers();
            manage.Show();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            Purchase purch = new Purchase();
            purch.Show();
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            Technical_Support tech = new Technical_Support();
            tech.Show();
        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will close the application. Do you wish to proceed?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Code to close the application
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_and_Signup logsign = new Login_and_Signup();
            logsign.Show();
            this.Close();
        }

        private void bunifuButton213_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Goodness_Pharmacy\\Goodness_pharm.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Get the values to be inserted from your Windows Form controls
                    int id = Convert.ToInt32(bunifuTextBoxCustomerId.Text);
                    string name = bunifuTextBoxCustomerName.Text;
                    string address = bunifuTextBoxCustomerAddress.Text;
                    int phone = Convert.ToInt32(bunifuTextBoxCustomerPhone.Text);

                    // Create the SQL insert query
                    string query = "INSERT INTO customer (Id, Name, Address, Phone) " +
                                   "VALUES (@Id, @Name, @Address, @Phone)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection and set their values
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Phone", phone);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();

                        // Display a success message or perform any additional tasks
                        MessageBox.Show("Customer data inserted successfully!");
                    }
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

        private void bunifuButton211_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Goodness_Pharmacy\\Goodness_pharm.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Get the values to be updated from your Windows Form controls
                    int id = Convert.ToInt32(bunifuTextBoxCustomerId.Text);
                    string name = bunifuTextBoxCustomerName.Text;
                    string address = bunifuTextBoxCustomerAddress.Text;
                    int phone = Convert.ToInt32(bunifuTextBoxCustomerPhone.Text);

                    // Create the SQL update query
                    string query = "UPDATE customer " +
                                   "SET Name = @Name, Address = @Address, Phone = @Phone " +
                                   "WHERE Id = @Id";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection and set their values
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Phone", phone);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();

                        // Display a success message or perform any additional tasks
                        MessageBox.Show("Customer data updated successfully!");

                        // Call the method to update the DataGridView in the "manage_customers" form
                        Manage_Customers manageCustomersForm = Application.OpenForms["ManageCustomersForm"] as Manage_Customers;
                        manageCustomersForm?.LoadCustomerData();
                    }

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

        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Get the purchase ID from your Windows Form control
                int id = Convert.ToInt32(bunifuTextBoxCustomerId.Text);

                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Goodness_Pharmacy\\Goodness_pharm.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create the SQL delete query
                    string query = "DELETE FROM Customer WHERE Id = @Id";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the purchase ID as a parameter to the query
                        command.Parameters.AddWithValue("@Id", id);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();

                        // Display a success message or perform any additional tasks
                        MessageBox.Show("Customer data deleted successfully!");

                        // Call the method to update the DataGridView in the "manage_purchase" form
                        Manage_Purchases managePurchaseForm = Application.OpenForms["ManagePurchaseForm"] as Manage_Purchases;
                        managePurchaseForm?.LoadPurchaseData();
                    }
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
}
