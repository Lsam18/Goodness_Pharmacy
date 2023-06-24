﻿using System;
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
    public partial class Employee_Login : Form
    {
        public Employee_Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Goodness_Pharmacy\\Goodness_pharm.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Get the login credentials from your Windows Form controls
                    string username = bunifuTextBoxUsername.Text; // Update with the correct control for username
                    string password = bunifuTextBoxPassword.Text; // Update with the correct control for password

                    // Create the SQL query to check if the user exists
                    string query = "SELECT COUNT(*) FROM Employeesign WHERE Username = @Username AND Password = @Password";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection and set their values
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Open the connection
                        connection.Open();

                        // Execute the query and get the result
                        int count = (int)command.ExecuteScalar();

                        // Check if the user exists
                        if (count > 0)
                        {
                            Program.UserRole = "employee"; //for employee privileges
                            // Successful login
                            MessageBox.Show("Login successful!");
                            Dashboard_Emp dashboardForm = new Dashboard_Emp();
                            dashboardForm.Show();
                            this.Close();
                            // Perform any additional tasks or navigate to the next page
                        }
                        else
                        {
                            // Invalid login credentials
                            MessageBox.Show("Invalid username or password!");
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
