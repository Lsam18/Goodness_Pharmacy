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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void bunifuButton214_Click(object sender, EventArgs e)
        {
            List_of_Medicines_Details list_Of_Medicines = new List_of_Medicines_Details();
            list_Of_Medicines.Show();
        }
    }
}
