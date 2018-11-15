using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Name = (txtName.Text);
            int HourlyWage;
            int SocialSecurtiy;
            int HoursWorked;
            double NetPay;
            double GrossPay;
            double Federal;
            double State;
            double Tax;
            HourlyWage = Convert.ToInt32(txtPayRate.Text);
            HoursWorked = Convert.ToInt32(txtHoursWorked.Text);
            SocialSecurtiy = Convert.ToInt32(txtSocial.Text);

            GrossPay = HourlyWage * HoursWorked;
            State = GrossPay / 5;
            Federal = GrossPay / 15;
            Tax = State + Federal;
            NetPay = GrossPay - Tax;

            lblGrossPay.Text = "" + GrossPay.ToString("C");
            lblFederal.Text = "" + Federal.ToString("C");
            lblState.Text = "" + State.ToString("C");
            lblNet.Text = "" + NetPay.ToString("C");
            






       
           
            
        }

        private void lblGrossPay_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
