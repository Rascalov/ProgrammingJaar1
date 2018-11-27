using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textGetal1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double getal1, getal2, getal3, getalGemmidelde;
            const int aantalGetallen = 3;
            getal1 = double.Parse(textGetal1.Text);
            getal2 = double.Parse(textGetal2.Text);
            getal3 = double.Parse(textGetal3.Text);

            getalGemmidelde = (getal1 + getal2 + getal3) / aantalGetallen;

            gemiddelde.Text = getalGemmidelde.ToString("0.000");
        }
    }
}
