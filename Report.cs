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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void bunifuButton214_Click(object sender, EventArgs e)
        {
            Sales_Report salesrep = new Sales_Report();
            salesrep.Show();
        }
    }
}
