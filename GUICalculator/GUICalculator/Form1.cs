using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            sum = num1 + num2;
            lblAdd.Text = "The sum is " + sum; 

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int differents;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            differents = num1 - num2;
            lblSubtract.Text = "The differents is " + differents;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int product;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            product = num1 * num2;
            lblMulitply.Text = "The products is " + product;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int divide;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            divide = num1 / num2;
            lblDivide.Text = "The Quotient is " + divide;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mod;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);

            mod = num1 % num2;
            lblMod.Text = "The Remainder is " + mod;
        }
    }
}
