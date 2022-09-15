using PoppelSolution.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelSolution.Business_Layer;

namespace PoppelSolution.Presentation_Layer
{
    public partial class CustomersRegistration : Form
    {
        private CustomerController customerController;
        private Customer customer;
        
        public CustomersRegistration()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
       
       private void AppendObject()
        {
                   customer = new Customer();
                customer.ID = textBoxID.Text;
                customer.Name = textBoxName.Text;
                customer.Phone = textBoxPhone.Text;
                customer.Email = textBoxEmail.Text;
                customer.Address = textBoxAddress.Text;
            
            


        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please Enter Your Name and Surname!", "Name not entered.", MessageBoxButtons.RetryCancel);
                textBoxName.Focus();
            }
            else if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Please Enter Your Email!", "Email not entered.", MessageBoxButtons.RetryCancel);
                textBoxEmail.Focus();
            }

            else if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Please Enter Your Phone Number!", "Phone Number not entered.", MessageBoxButtons.RetryCancel);
                textBoxPhone.Focus();
            }

            else if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Please Enter Your Address!", "Address not entered.", MessageBoxButtons.RetryCancel);
                textBoxAddress.Focus();
            }

            else 
            {
                if (ValidData())
                {
                    //submit to Database
                    AppendObject();
                    MessageBox.Show("The Customer has been registered!");
                    customerController.DataMaintenance(customer, DB.DBOperation.Add);
                    customerController.FinalizeChanges();
                    CustomersList form = new CustomersList();
                    form.Show();
                    this.Close();
                }

            }

        }

        //Call validation method to validate the textboxes of their data type
        private bool ValidData()
        {
            return
            Validation.ValidateString(textBoxName.Text)&&
            Validation.PhoneValidate(textBoxPhone);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomersList form = new CustomersList();
            form.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private void CustomersRegistration_Load(object sender, EventArgs e)
        {
            //Creating A random ID
            Random random = new Random();
            int id = random.Next(0, 100000000);
            textBoxID.Text = id.ToString();
            
            //Calling The Controllerclass
            customerController = new CustomerController();

            if (!String.IsNullOrEmpty(textBoxName.Text) && !String.IsNullOrEmpty(textBoxPhone.Text) && !String.IsNullOrEmpty(textBoxEmail.Text) && !String.IsNullOrEmpty(textBoxAddress.Text))
            {
                registerBtn.Enabled = true;
            }
        }
    }
}
