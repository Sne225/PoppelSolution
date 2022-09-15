using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PoppelSolution.Presentation_Layer
{
    public partial class OrderProcedure : Form
    {
        
        double tax = 0.15;
        double Tax = 0;
        const double chocolate = 10;
        const double whiteChocolate = 12;
        const double Fizzus = 6;
        const double chips = 7.50;
        const double lollipop = 3;
        const double iceCream = 9;
        const double fantaPine = 16;
        const double sprite = 18;
        const double toffee = 9;
        double amount = 0;
        double totalprice;
        
        ListViewItem orders;
        public OrderProcedure()
        {
            InitializeComponent();
        }
      

        private void OrderProcedure_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'poppelSolutionDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.poppelSolutionDatabaseDataSet.Customers);

            //Loading the prices
            label9.Text = chocolate.ToString("C");
            label10.Text = whiteChocolate.ToString("C");
            label11.Text = Fizzus.ToString("C");
            label12.Text = chips.ToString("C");
            label13.Text = lollipop.ToString("C");
            label14.Text = iceCream.ToString("C");
            label15.Text = fantaPine.ToString("C");
            label16.Text = sprite.ToString("C");
            label17.Text = toffee.ToString("C");
            


            //Creating a List View
            listView1.Columns.Insert(0, "Order Names", 130, HorizontalAlignment.Left);
            listView1.Columns.Insert(1, "Quantity", 70, HorizontalAlignment.Left);
            listView1.Columns.Insert(2, "Price", 70, HorizontalAlignment.Left);

            label19.Text = DateTime.Now.ToLongDateString();




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        #region //Check Events to enable or disable
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
      {
            
            if (checkBox1.Checked)
              {
                  chocTxt.Enabled = true;
              }
           else if (checkBox1.Checked == false)
            {
                chocTxt.Clear();
                chocTxt.Enabled = false;
            }
          }
         
          private void checkBox2_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox2.Checked)
              {
                  whiteChocTxt.Enabled = true;                  
              }
            else if (checkBox2.Checked == false)
            {
                whiteChocTxt.Clear();
                whiteChocTxt.Enabled = false;
            }
        }

          private void checkBox3_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox3.Checked)
              {
                  fizzusTxt.Enabled = true;                  
              }
            else if (checkBox3.Checked == false)
            {
                fizzusTxt.Clear();
                fizzusTxt.Enabled = false;
            }
        }

          private void checkBox4_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox4.Checked)
              {
                  chipsTxt.Enabled = true;
              }
            else if (checkBox4.Checked == false)
            {
                chipsTxt.Clear();
                chipsTxt.Enabled = false;
            }
        }

          private void checkBox5_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox5.Checked)
              {
                  lollipopTxt.Enabled = true;
              }
            else if (checkBox5.Checked == false)
            {
                lollipopTxt.Clear();
                lollipopTxt.Enabled = false;
            }
        }

          private void checkBox6_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox6.Checked)
              {
                  iceTxt.Enabled = true;
                  amount = +iceCream;
              }
            else if (checkBox6.Checked == false)
            
            {
                iceTxt.Clear();
                iceTxt.Enabled = false;
            }
        }

          private void checkBox7_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox7.Checked)
              {
                  fantaTxt.Enabled = true;
                  amount = +fantaPine;
              }
            else if (checkBox7.Checked == false)
            {
                fantaTxt.Clear();
                fantaTxt.Enabled = false;
            }

        }

          private void checkBox8_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox8.Checked)
              {
                  spriteTxt.Enabled = true;
                  amount = +sprite;
              }
            else if (checkBox8.Checked == false)
            {
                spriteTxt.Clear();
                spriteTxt.Enabled = false;
            }
        }

          private void checkBox9_CheckedChanged(object sender, EventArgs e)
          {
              if (checkBox9.Checked)
              {
                  toffeTxt.Enabled = true;
                  amount = +toffee;
              }
            else if (checkBox9.Checked == false)
            {
                toffeTxt.Clear();
                toffeTxt.Enabled = false;
            }
        }
        #endregion

        private void registerBtn_Click(object sender, EventArgs e)
          {
              textBox1.Text = amount.ToString("C");
          }
  
        private void button2_Click(object sender, EventArgs e)
        {
            CustomersList list = new CustomersList();
            list.Show();
            this.Close();
        }

        private void fizzusTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Calculate();
            UnCHeck();
        }

        private void UnCHeck()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            
        }

        public void Calculate()
        {
            try
            {

                double amount1 = 0;
                if (checkBox1.Checked)
                {
                    double quantity = double.Parse(chocTxt.Text);
                    //  double quantity = double.Parse(chocTxt.Text);

                    orders = new ListViewItem();
                   
                    amount1 = quantity* chocolate;

                    orders.Text = "Chocolate";
                    orders.SubItems.Add("    " + chocTxt.Text);
                    orders.SubItems.Add("    " + amount1.ToString("C"));
                    listView1.Items.Add(orders);
                }

                double amount2 = 0;
                if (checkBox2.Checked)
                {
                    double quantity = double.Parse(whiteChocTxt.Text);
                    //  double quantity = double.Parse(chocTxt.Text);
                    orders = new ListViewItem();
                   
                    amount2 = quantity* whiteChocolate;

                    orders.Text = "White Chocolate";
                    orders.SubItems.Add("    " + whiteChocTxt.Text);
                    orders.SubItems.Add("    " + amount2.ToString("C"));
                    listView1.Items.Add(orders);


                }

                double amount3 = 0;
                if (checkBox3.Checked)
                {
                    double quantity = double.Parse(fizzusTxt.Text);
                    //  double quantity = double.Parse(chocTxt.Text);
                    orders = new ListViewItem();
                  
                    amount3 = quantity* Fizzus;

                    orders.Text = "Fizzuz";
                    orders.SubItems.Add("    " + fizzusTxt.Text);
                    orders.SubItems.Add("    " + amount3.ToString("C"));
                    listView1.Items.Add(orders);


                }

                double amount4 = 0;
                 if (checkBox4.Checked)
                {
                    double quantity = double.Parse(chipsTxt.Text);
                    orders = new ListViewItem();

                    
                    amount4 = quantity* chips;
                    orders.Text = "Chips";
                    orders.SubItems.Add("    " + chipsTxt.Text);
                    orders.SubItems.Add("    " + amount4.ToString("C"));
                    listView1.Items.Add(orders);
                }

                double amount5 = 0;
                if (checkBox5.Checked)
                {
                    orders = new ListViewItem();
                    double quantity = double.Parse(lollipopTxt.Text);

                    
                    amount5 = quantity* lollipop;
                    orders.Text = "Lollipop";
                    orders.SubItems.Add("    " + lollipopTxt.Text);
                    orders.SubItems.Add("    " + amount5.ToString("C"));
                    listView1.Items.Add(orders);

                }

                double amount6 = 0;
                if (checkBox6.Checked)
                {
                    orders = new ListViewItem();
                    double quantity = double.Parse(iceTxt.Text);

                    
                    amount6 = quantity* iceCream;
                    orders.Text = "Ice Cream";
                    orders.SubItems.Add("    " + iceTxt.Text);
                    orders.SubItems.Add("    " + amount6.ToString("C"));
                    listView1.Items.Add(orders);
                }

                double amount7 = 0;
                if (checkBox7.Checked)
                {
                    orders = new ListViewItem();                   
                    double quantity = double.Parse(fantaTxt.Text);

                    
                    amount7 = quantity* fantaPine;
                    orders.Text = "Fanta";
                    orders.SubItems.Add("    " + fantaTxt.Text);
                    orders.SubItems.Add("    " + amount7.ToString("C"));
                    listView1.Items.Add(orders);
                }

                double amount8 = 0;
                if (checkBox8.Checked)
                {
                    orders = new ListViewItem();
                    double quantity = double.Parse(spriteTxt.Text);

                    
                    amount8 = quantity * sprite;
                    orders.Text = "Sprite";
                    orders.SubItems.Add("    " + spriteTxt.Text);
                    orders.SubItems.Add("    " + amount8.ToString("C"));
                    listView1.Items.Add(orders);
                }

                double amount9 = 0;
                if (checkBox9.Checked)
                {
                    orders = new ListViewItem();
                    double quantity = double.Parse(toffeTxt.Text);

                    
                    amount9 = quantity * toffee;
                    orders.Text = "Toffe";
                    orders.SubItems.Add("    " + toffeTxt.Text);
                    orders.SubItems.Add("    " + amount9.ToString("C"));
                    listView1.Items.Add(orders);
                }

                amount = amount1 + amount2 + amount3 + amount4 + amount5 + amount6 + amount7 + amount8 + amount9;
                textBox1.Text = amount.ToString("C");
                Tax = amount * tax;
                textBox10.Text = Tax.ToString("C");
                totalprice = amount + Tax;
                textBox11.Text = totalprice.ToString("C");


            }
             catch (FormatException error)
            {

                MessageBox.Show("Error data input. Please input a number" + "\r\n" + "---------------------------------------------------" +
                    "\r\n" + error.Message, "Error input data type", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
            }

        }

       
     

        private void subTotat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void lollipopTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //declarations
            Font BodyFont = new Font("Arial", 14);
            Font HeadingFont = new Font("Arial", 16, FontStyle.Bold);
            float HeadingLineSpacing = HeadingFont.GetHeight() + 2;
            float BodyLineSpacing = BodyFont.GetHeight() + 2;
            float HorizontalPrintMargin = e.MarginBounds.Left;
            float VerticalPrintMargin = e.MarginBounds.Top;
            string StringToPrint;

            // Print headings
            StringToPrint = "Picking List For " + comboBox1.Text;
            e.Graphics.DrawString(StringToPrint, HeadingFont, Brushes.Black,
           HorizontalPrintMargin, VerticalPrintMargin);
            //Leave a blank line between the headings and the sports information
            VerticalPrintMargin += HeadingLineSpacing * 2;
            
            //Looping Into The ListView
            for(int i = 0; i < listView1.Items.Count; i++)
            {

                // Draw the row for orders on print preview
                e.Graphics.DrawString("  " + listView1.Items[i].SubItems[0].Text + listView1.Items[i].SubItems[1].Text +
                  listView1.Items[i].SubItems[2].Text, BodyFont, Brushes.Black, HorizontalPrintMargin, VerticalPrintMargin);
                VerticalPrintMargin += BodyLineSpacing;
               
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dialog result to confirm for exiting app
            DialogResult res = MessageBox.Show("Do you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }
    }
}
