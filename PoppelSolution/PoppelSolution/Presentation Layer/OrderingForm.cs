using PoppelSolution.Business_Layer;
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

namespace PoppelSolution.Presentation_Layer
{
    public partial class OrderingForm : Form
    {
        private Collection<Order> orders;
        private orderController OrderController;

        public OrderingForm()
        {
            InitializeComponent();
            OrderController = new orderController();
        }
        public void ListViewSetUp()
        {
            ListViewItem orderDetails;
            //Clear current List View Control
            listView.Clear();

            //Set Up Columns of List View

            listView.Columns.Insert(0, "DateCreated", 120, HorizontalAlignment.Left);
            listView.Columns.Insert(1, "OrderID", 120, HorizontalAlignment.Left);
            listView.Columns.Insert(2, "CustomerID", 150, HorizontalAlignment.Left);
            

            orders = OrderController.AllOrders;

            //Add employee details to each ListView item 

            foreach (Order order in orders)
            {
                orderDetails = new ListViewItem();

               
                orderDetails.Text = order.DateCreated.ToString();
                orderDetails.SubItems.Add(order.OrderID);
                orderDetails.SubItems.Add(order.CustomerId);

                listView.Items.Add(orderDetails);

            }

            listView.Refresh();
            listView.GridLines = true;
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            OrderProcedure form = new OrderProcedure();
            form.Show();
            this.Close();
        }

        private void OrderingForm_Activated(object sender, EventArgs e)
        {

        }

        private void OrderingForm_Load(object sender, EventArgs e)
        {
            ListViewSetUp();
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Close();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            CustomersList list = new CustomersList();
            list.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dialog result to confirm for exiting app
            DialogResult res = MessageBox.Show("Do you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.Show();
            this.Close();
        }
    }
}
