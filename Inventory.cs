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
            List_of_Medicines_Main list_Of_Medicines_Main = new List_of_Medicines_Main();
            list_Of_Medicines_Main.Show();
        }

        private void bunifuButton215_Click(object sender, EventArgs e)
        {
            Medicine_Groups medicine_Groups = new Medicine_Groups();
            medicine_Groups.Show();
        }
    }
}
