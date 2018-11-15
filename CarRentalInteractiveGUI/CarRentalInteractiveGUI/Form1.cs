using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days;
            double miles;
            double Total;
            days = Convert.ToInt32(txtDays.Text);
            miles = Convert.ToInt32(txtMiles.Text);
            Total = (miles * .25) + (days * 20);
            lblTotalFee.Text = "Your Total Fee Is " + Total.ToString("C"); 
            
        }
    }
}
