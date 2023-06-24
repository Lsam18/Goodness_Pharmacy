using System.Windows.Forms;

namespace Goodness_Pharmacy
{
    public partial class List_of_Medicines_Details : Form
    {
        public List_of_Medicines_Details()
        {
            InitializeComponent();
            linkLabel2.Text = Program.UserRole + " - Sign Out";
            bunifuLabel3.Text = Program.UserName;
        }

        private void bunifuButton26_Click(object sender, System.EventArgs e)
        {
            List_of_Medicines_Main list_ = new List_of_Medicines_Main();
            list_.Show();
        }

        private void bunifuButton218_Click(object sender, System.EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Close();
        }

        private void bunifuButton217_Click(object sender, System.EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Close();
        }

        private void bunifuButton216_Click(object sender, System.EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Close();
        }

        private void bunifuButton215_Click(object sender, System.EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Close();
        }

        private void bunifuButton214_Click(object sender, System.EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
            this.Close();
        }

        private void bunifuButton213_Click(object sender, System.EventArgs e)
        {
            Purchase purch = new Purchase();
            purch.Show();
            this.Close();
        }

        private void bunifuButton212_Click(object sender, System.EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
            this.Close();
        }

        private void bunifuButton211_Click(object sender, System.EventArgs e)
        {
            Technical_Support tech = new Technical_Support();
            tech.Show();
            this.Close();
        }

        private void bunifuButton210_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will close the application. Do you wish to proceed?", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
