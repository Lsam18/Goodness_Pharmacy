﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            Manage_Purchases manage_purch =   new Manage_Purchases();
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
    }
}
