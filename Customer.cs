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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {
            Manage_Customers manage = new Manage_Customers();
            manage.Show();
        }
    }
}
