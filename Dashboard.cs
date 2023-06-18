using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodness_Pharmacy
{
    public partial class Dashboard : Form
    {
        

        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_and_Signup logsign = new Login_and_Signup();
            logsign.Show();

           

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Hide();
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Hide();
        }
    }
}
