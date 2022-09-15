using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelSolution;
namespace PoppelSolution.Presentation_Layer
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poppelSolutionDatabaseDataSet2.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.poppelSolutionDatabaseDataSet2.Products);
            // TODO: This line of code loads data into the 'poppelSolutionDatabaseDataSet1.Products' table. You can move, or remove it, as needed.
            

        }

        private void productExpiredToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Expired_Products(this.poppelSolutionDatabaseDataSet2.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void productFreshToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fresh_Products(this.poppelSolutionDatabaseDataSet2.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DashboardForm orders = new DashboardForm();
            orders.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            int height=dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;

          
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Draw Header
            e.Graphics.DrawString("Expired Products In Inventory",
                        new Font(dataGridView1.Font, FontStyle.Bold),
                        Brushes.Black, e.MarginBounds.Left,
                        e.MarginBounds.Top - e.Graphics.MeasureString("Expired Products In Inventory",
                        new Font(dataGridView1.Font, FontStyle.Bold),
                        e.MarginBounds.Width).Height - 13);

            String strDate = DateTime.Now.ToLongDateString() + " " +
                DateTime.Now.ToShortTimeString();
            //Draw Date
            e.Graphics.DrawString(strDate,
                new Font(dataGridView1.Font, FontStyle.Bold), Brushes.Black,
                e.MarginBounds.Left +
                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                new Font(dataGridView1.Font, FontStyle.Bold),
                e.MarginBounds.Width).Width),
                e.MarginBounds.Top - e.Graphics.MeasureString("Expired Products In Inventory",
                new Font(new Font(dataGridView1.Font, FontStyle.Bold),
                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

            e.Graphics.DrawImage(bitmap, 0, 0);
          
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.Show();
            this.Close();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OrderingForm form = new OrderingForm();
            form.Show();
            this.Close();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            CustomersList form = new CustomersList();
            form.Show();
            this.Close();
        }

        private void productExpiredToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void displayExpiredProductsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.DisplayExpiredProducts(this.poppelSolutionDatabaseDataSet2.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fresh_ProductsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Fresh_Products(this.poppelSolutionDatabaseDataSet2.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void expired_ProductsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter.Expired_Products(this.poppelSolutionDatabaseDataSet2.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
