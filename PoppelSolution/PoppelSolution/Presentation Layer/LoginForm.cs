using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelSolution
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Check if the the textboxes are empty. If so, then the program won't run
            if (usernameTxt.Text == "")
            {
                MessageBox.Show("Please enter your username on the field below!", "Username Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Focus();

              
            }
            else
            {
                if (passwordTxt.Text == "")
                {
                    MessageBox.Show("Please enter your password on the field below!", "Password Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    passwordTxt.Focus();
                }
                //if data provided, then move to the loading form
                else
                {
                    if (usernameTxt.Text == "admin" && passwordTxt.Text == "admin")
                    {
                        LoadingForm load = new LoadingForm();
                        load.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Please enter the correct username and password!", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
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

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            //Show password if clicked on the icon of the password
            passwordTxt.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            //Hide password if stopped clicking on the icon of the password
            passwordTxt.UseSystemPasswordChar = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Your password is made up of five small letters that describes your role :)", "Hint For Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
