using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelInvoer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBereken_Click(object sender, EventArgs e)
        {
            String invoer = textBox1.Text;
            double prijs = double.Parse(invoer);
            const double BTW = 21.00;
            double btwWaarde = prijs * (BTW / 100);
            double totaalPrijs = prijs * (1.00 + (BTW / 100));



            label4.Text = prijs.ToString("0.00");
            label5.Text = btwWaarde.ToString("0.00");
            label6.Text = totaalPrijs.ToString("0.00");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
