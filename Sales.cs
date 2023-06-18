using System;
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
    }
}
