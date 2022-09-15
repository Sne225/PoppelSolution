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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Animate the loading tank 
            panel1.Width += 2;


            if (panel1.Width >= 630)
            {
                //Stop after some time and open Order Form
                timer1.Stop();

                DashboardForm order = new DashboardForm();
                order.Show();
                this.Hide();
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
