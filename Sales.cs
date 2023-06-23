using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void bunifuButton211_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
        }

        private void bunifuButton213_Click(object sender, EventArgs e)
        {
            string selectedOption = Select_supplier_sales.SelectedItem.ToString();
            
            string selectedOption2 = Sales_Category_Sales.SelectedItem.ToString();

            string selectedOption3 = Medicine_Sales.SelectedItem.ToString();

            string selectedOption4 = Quantity_Sales.SelectedItem.ToString();
            MessageBox.Show("Selected Options: " + selectedOption + ", " + selectedOption2 + ", " + selectedOption3 + ", " + selectedOption4);





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

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            Purchase purch = new Purchase();
            purch.Show();
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            Technical_Support tech = new Technical_Support();
            tech.Show();
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
    }
}
