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
    }
}
