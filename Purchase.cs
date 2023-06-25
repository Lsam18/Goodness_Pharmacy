using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodness_Pharmacy
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
            linkLabel1.Text = Program.UserRole + " - Sign Out";
            bunifuLabel2.Text = Program.UserName;
        }

        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            Manage_Purchases manage_purch = new Manage_Purchases();
            manage_purch.Show();
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
            Report report = new Report();
            report.Show();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
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
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Goodness_Pharmacy\\Goodness_pharm.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Get the values to be inserted from your Windows Form controls
                    int id = Convert.ToInt32(bunifuTextBoxPurchaseId.Text);
                    string supplierName = comboBoxSupplierName.SelectedItem?.ToString(); // Get selected item from ComboBox
                    int invoiceNo = Convert.ToInt32(bunifuTextBoxInvoiceNo.Text);
                    DateTime purchaseDate = bunifuDatePickerPurchaseDate.Value;
                    string details = bunifuTextBoxPurchaseDetails.Text;
                    int quantity = Convert.ToInt32(bunifuTextBoxPurchaseQuantity.Text);
                    float total = float.Parse(bunifuTextBoxPurchaseTotal.Text);

                    // Create the SQL insert query
                    string query = "INSERT INTO Purchase (Id, Supplier_Name, Invoice_No, Purchase_Date, Details, Quantity, Total) " +
                                   "VALUES (@Id, @SupplierName, @InvoiceNo, @PurchaseDate, @Details, @Quantity, @Total)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection and set their values
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@SupplierName", supplierName);
                        command.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                        command.Parameters.AddWithValue("@Details", details);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Total", total);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();

                        // Display a success message or perform any additional tasks
                        MessageBox.Show("Purchase data inserted successfully!");
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
                    // Get the values to be inserted from your Windows Form controls
                    int id = Convert.ToInt32(bunifuTextBoxPurchaseId.Text);
                    string supplierName = comboBoxSupplierName.SelectedItem?.ToString(); // Get selected item from ComboBox
                    int invoiceNo = Convert.ToInt32(bunifuTextBoxInvoiceNo.Text);
                    DateTime purchaseDate = bunifuDatePickerPurchaseDate.Value;
                    string details = bunifuTextBoxPurchaseDetails.Text;
                    int quantity = Convert.ToInt32(bunifuTextBoxPurchaseQuantity.Text);
                    float total = float.Parse(bunifuTextBoxPurchaseTotal.Text);

                    // Create the SQL insert query
                    string query = "INSERT INTO Purchase (Id, Supplier_Name, Invoice_No, Purchase_Date, Details, Quantity, Total) " +
                                   "VALUES (@Id, @SupplierName, @InvoiceNo, @PurchaseDate, @Details, @Quantity, @Total)";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection and set their values
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@SupplierName", supplierName);
                        command.Parameters.AddWithValue("@InvoiceNo", invoiceNo);
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                        command.Parameters.AddWithValue("@Details", details);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Total", total);

                        // Open the connection
                        connection.Open();

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Close the connection
                        connection.Close();

                        // Display a success message or perform any additional tasks
                        MessageBox.Show("Purchase data inserted successfully!");
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
                MessageBox.Show("An exception occurred");
        }
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {
            // Assuming you have a button named "btnClear"


            // Clear the text boxes
            bunifuTextBoxPurchaseId.Text = string.Empty;
            comboBoxSupplierName.SelectedIndex = -1;
            bunifuTextBoxInvoiceNo.Text = string.Empty;
            bunifuDatePickerPurchaseDate.Value = DateTime.Today;
            bunifuTextBoxPurchaseDetails.Text = string.Empty;
            bunifuTextBoxPurchaseQuantity.Text = string.Empty;
            bunifuTextBoxPurchaseTotal.Text = string.Empty;


        }

        private void Purchase_Load(object sender, EventArgs e)
        {

            // Clear the existing items in the dropdown
            comboBoxSupplierName.Items.Clear();

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
                                    comboBoxSupplierName.Items.Add(supplierName);
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

        private void comboBoxSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected Supplier from the dropdown
            string selectedSupplier = comboBoxSupplierName.SelectedItem?.ToString();

            // Check if a Supplier is selected
            if (!string.IsNullOrEmpty(selectedSupplier))
            {
                // Perform actions based on the selected Supplier
                // For example, you can display additional information about the Supplier or retrieve related data from the database.
                MessageBox.Show("You double-clicked on Supplier: " + selectedSupplier);
            }
        }
    }
    }
