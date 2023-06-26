using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodness_Pharmacy
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            linkLabel1.Text = Program.UserRole + " - Sign Out";
            bunifuLabel2.Text = Program.UserName;
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {
            Manage_Suppliers managesup =  new Manage_Suppliers();
            managesup.Show();
            this.Close();

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
            if (Program.UserRole == "Admin")
            {
                Sales_Report salesrep = new Sales_Report();
                salesrep.Show();
                this.Close();
            }
            else
                MessageBox.Show("You do not have permission to access this");
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
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

                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Login_and_Signup logsign = new Login_and_Signup();
                logsign.Show();
                this.Hide();

            }
        }
       




        private void bunifuButton213_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Goodness Pharmacy\Goodness_pharm.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Get the values to be inserted from your Windows Form controls
                    int id = Convert.ToInt32(bunifuTextBoxSupplierIdsup.Text);
                    string name = bunifuTextBoxSupplierNamesup.Text;
                    string address = bunifuTextBoxCustomerAddresssup.Text;
                    int phone = Convert.ToInt32(bunifuTextBoxSupplierPhonesup.Text);

                    // Create the SQL insert query
                    string query = "INSERT INTO Supplier (Id, Name, Address, Phone) " +
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
                        MessageBox.Show("Supplier data inserted successfully!");
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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Goodness Pharmacy\Goodness_pharm.mdf"";Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Get the values to be updated from your Windows Form controls
                    int id = Convert.ToInt32(bunifuTextBoxSupplierIdsup.Text);

                    // Create the SQL update query
                    string query = "UPDATE Supplier SET ";

                    // Create a flag variable to track if any optional field has been filled
                    bool isOptionalFieldFilled = false;

                    // Check if the name field is filled
                    if (!string.IsNullOrWhiteSpace(bunifuTextBoxSupplierNamesup.Text))
                    {
                        query += "Name = @Name, ";
                        isOptionalFieldFilled = true;
                    }

                    // Check if the address field is filled
                    if (!string.IsNullOrWhiteSpace(bunifuTextBoxCustomerAddresssup.Text))
                    {
                        query += "Address = @Address, ";
                        isOptionalFieldFilled = true;
                    }

                    // Check if the phone field is filled
                    if (!string.IsNullOrWhiteSpace(bunifuTextBoxSupplierPhonesup.Text))
                    {
                        int phone = Convert.ToInt32(bunifuTextBoxSupplierPhonesup.Text);
                        query += "Phone = @Phone, ";
                        isOptionalFieldFilled = true;
                    }

                    // Check if any optional field has been filled
                    if (!isOptionalFieldFilled)
                    {
                        MessageBox.Show("At least one field should be filled to perform an update.");
                        return;
                    }

                    // Remove the trailing comma and space from the query
                    query = query.TrimEnd(',', ' ');

                    // Add the condition for the ID
                    query += " WHERE Id = @Id";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the ID parameter
                        command.Parameters.AddWithValue("@Id", id);

                        // Add the optional parameters
                        if (query.Contains("@Name"))
                            command.Parameters.AddWithValue("@Name", bunifuTextBoxSupplierNamesup.Text);

                        if (query.Contains("@Address"))
                            command.Parameters.AddWithValue("@Address", bunifuTextBoxCustomerAddresssup.Text);

                        if (query.Contains("@Phone"))
                        {
                            int phone = Convert.ToInt32(bunifuTextBoxSupplierPhonesup.Text);
                            command.Parameters.AddWithValue("@Phone", phone);
                        }

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            // Display a success message or perform any additional tasks
                            MessageBox.Show("Supplier data updated successfully!");

                            // Call the method to update the DataGridView in the "manage_supplier" form
                            Manage_Suppliers manageSupplierForm = Application.OpenForms["ManageSupplierForm"] as Manage_Suppliers;
                            manageSupplierForm?.LoadSupplierData();
                        }
                        else
                        {
                            MessageBox.Show("No supplier found with the specified ID.");
                        }
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
            // Get the purchase ID from your Windows Form control
            try
            {
                // Get the supplier ID from your Windows Form control
                int id = Convert.ToInt32(bunifuTextBoxSupplierIdsup.Text);

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Goodness Pharmacy\Goodness_pharm.mdf"";Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create the SQL delete query
                    string query = "DELETE FROM Supplier WHERE Id = @Id";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the supplier ID as a parameter to the query
                        command.Parameters.AddWithValue("@Id", id);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            // Display a success message or perform any additional tasks
                            MessageBox.Show("Supplier data deleted successfully!");

                            // Call the method to update the DataGridView in the "manage_supplier" form
                            Manage_Suppliers manageSupplierForm = Application.OpenForms["ManageSupplierForm"] as Manage_Suppliers;
                            manageSupplierForm?.LoadSupplierData();
                        }
                        else
                        {
                            MessageBox.Show("No supplier found with the specified ID.");
                        }
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
