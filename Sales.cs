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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Goodness_Pharmacy
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            linkLabel1.Text = Program.UserRole + " - Sign Out";
            bunifuLabel2.Text = Program.UserName;
        }

        private void bunifuButton211_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
        }

        private void bunifuButton213_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Goodness_Pharmacy\\Goodness_pharm.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Get the values to be inserted from your Windows Form controls
                    int saleCode = Convert.ToInt32(bunifuTextBox3.Text);
                    string supplierName = bunifuDropdownSupplierName.SelectedItem?.ToString();
                    DateTime date = bunifuDatePickerDate.Value;
                    string category = bunifuDropdownCategory.SelectedItem?.ToString();
                    string medicine = bunifuDropdownMedicine.SelectedItem?.ToString();
                    int quantity = Convert.ToInt32(bunifuTextBoxQuantity.Text);
                    string notes = bunifuTextBoxNotes.Text;
                    float discount = Convert.ToSingle(bunifuTextBoxDiscount.Text);
                    float grandTotal = Convert.ToSingle(bunifuTextBoxGrandTotal.Text);
                    string payment = bunifuDropdownPayment.SelectedItem?.ToString();

                    // Perform form validation
                    if (string.IsNullOrEmpty(supplierName) ||
                        string.IsNullOrEmpty(category) ||
                        string.IsNullOrEmpty(medicine) ||
                        string.IsNullOrEmpty(payment))
                    {
                        MessageBox.Show("Please fill in all the required fields.");
                        return; // Stop further execution
                    }

                    // Create the SQL insert query
                    string query = "INSERT INTO Sales (Sale_Code, Supplier_Name, Date, Category, Medicine, Quantity, Notes, Discount, Grand_Total, Payment) " +
                                   "VALUES (@SaleCode, @SupplierName, @Date, @Category, @Medicine, @Quantity, @Notes, @Discount, @GrandTotal, @Payment)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection and set their values
                        command.Parameters.AddWithValue("@SaleCode", saleCode);
                        command.Parameters.AddWithValue("@SupplierName", supplierName);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@Medicine", medicine);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Notes", notes);
                        command.Parameters.AddWithValue("@Discount", discount);
                        command.Parameters.AddWithValue("@GrandTotal", grandTotal);
                        command.Parameters.AddWithValue("@Payment", payment);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();

                        // Display a success message or perform any additional tasks
                        MessageBox.Show("Data inserted successfully!");
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
            this.Close();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
            this.Close();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            Purchase purch = new Purchase();
            purch.Show();
            this.Close();
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            Technical_Support tech = new Technical_Support();
            tech.Show();
            this.Close();
        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Select_supplier_sales_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Supplier from the dropdown
            string selectedSupplier = bunifuDropdownSupplierName.SelectedItem?.ToString();

            // Check if a Supplier is selected
            if (!string.IsNullOrEmpty(selectedSupplier))
            {
                // Perform actions based on the selected Supplier
                // For example, you can display additional information about the Supplier or retrieve related data from the database.
                MessageBox.Show("You double-clicked on Supplier: " + selectedSupplier);
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {

            // Clear the existing items in the dropdown
            bunifuDropdownSupplierName.Items.Clear();

            try
            {
                // Establish the database connection
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Goodness_Pharmacy\\Goodness_pharm.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    // Create the SQL query to fetch suppliers
                    string query = "SELECT Name FROM Supplier";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and retrieve the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if there are rows returned
                            if (reader.HasRows)
                            {
                                // Iterate through the rows and add suppliers to the dropdown
                                while (reader.Read())
                                {
                                    string supplierName = reader.GetString(0);
                                    bunifuDropdownSupplierName.Items.Add(supplierName);
                                }
                            }
                        }

                        // Close the connection
                        connection.Close();
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
