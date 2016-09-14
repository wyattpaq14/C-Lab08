using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_08_Calc_Reservation
{
    public partial class Form1 : Form
    {


        const double pricePerNight = 115.00;
        double totalPrice = 0.0;
        int numOfNights = 0;


        public Form1()
        {
            InitializeComponent();
            txtADate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime arrivalDate = DateTime.Parse(txtADate.Text);
                DateTime depDate = DateTime.Parse(txtDDate.Text);
                TimeSpan nightTime = depDate - arrivalDate;

                numOfNights = nightTime.Days;
                


                totalPrice = (numOfNights * pricePerNight);

                string message = "Days: " + numOfNights + "\nPrice: " + "$" + totalPrice;
                //final print


                txtNumNights.Text = numOfNights.ToString();
                txtPrice.Text = "$" + totalPrice.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter valid dates! (mm/dd/yy)", "ERROR!");
            }


        }

        private void txtChangeAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button1_Click(sender, e);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
