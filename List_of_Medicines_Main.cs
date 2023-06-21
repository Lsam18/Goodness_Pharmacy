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
    public partial class List_of_Medicines_Main : Form
    {
        public List_of_Medicines_Main()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Add_Medicine addmed = new Add_Medicine();
            addmed.Show();
        }
    }
}
