using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelSolution.Business_Layer;
using PoppelSolution.DatabaseLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PoppelSolution.Presentation_Layer
{
    public partial class CustomersList : Form
    {
        #region Data Members
        private Collection<Customer> customers;
        private CustomerController customerController;
        
        #endregion

        public CustomersList()
        {
            InitializeComponent();
            customerController = new CustomerController();  

        }

        public void ListViewSetUp()
        {
            ListViewItem customerDetails;
            //Clear current List View Control
            listView.Clear();

            //Set Up Columns of List View

            listView.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
            listView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            listView.Columns.Insert(2, "Phone", 150, HorizontalAlignment.Left);
            listView.Columns.Insert(3, "Email", 100, HorizontalAlignment.Left);
            listView.Columns.Insert(4, "Address", 100, HorizontalAlignment.Center);

            customers = customerController.AllCustomers;

            //Add employee details to each ListView item 

            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();

                customerDetails.Text = customer.ID.ToString();
                customerDetails.SubItems.Add(customer.Name);
                customerDetails.SubItems.Add(customer.Phone);
                customerDetails.SubItems.Add(customer.Email);
                customerDetails.SubItems.Add(customer.Address);

                listView.Items.Add(customerDetails);

            }

            listView.Refresh();
            listView.GridLines = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Show cusstomerForm for registration
            CustomersRegistration customers = new CustomersRegistration();
            customers.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void CustomersList_Load(object sender, EventArgs e)
        {
           
        }

        private void CustomersList_Activated(object sender, EventArgs e)
        {
            ListViewSetUp();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Show cusstomerForm for registration
            OrderProcedure customers = new OrderProcedure();
            customers.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //dialog result to confirm for exiting app
            DialogResult res = MessageBox.Show("Do you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Close();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLower_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonMarketing_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OrderingForm form = new OrderingForm();
            form.Show();
            this.Close();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
