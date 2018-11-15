using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnPress_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int c;

            a = Convert.ToInt32(txtNumber.Text);
            b = Convert.ToInt32(txtNumber2.Text);

            c = a - b;

            lblDragon.Text = "The " + txtColor.Text + " Dragon is the " + txtEST.Text + " Dragon of all.  It has " + txtBodyPart.Text + " and a "
 + txtAnimal.Text + " shaped like a " + txtNoun.Text + ". It loves to eat " + txtPlural.Text + " although it will feast on nearly anything."; 
        }
    }
}
