using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht8
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelTotaalPrijs_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Datum = DateTime.Now;

            const double KOSTEN_SHIRT = 30.00;
            const double KOSTEN_BROEK = 100.00;
            const double BTW = 0.21;
            int aantalShirts, aantalBroeken;
            double prijs, prijsBTW, prijsTotaal;

            aantalShirts = int.Parse(textBoxShirt.Text);
            aantalBroeken = int.Parse(textBoxBroek.Text);


            prijs = (aantalShirts * KOSTEN_SHIRT) + (aantalBroeken * KOSTEN_BROEK);
            prijsBTW = prijs * BTW;
            prijsTotaal = prijs * (1 + BTW);


            
            labelDatum.Text = Datum.ToString();
            labelPrijs.Text = "€ " + prijs.ToString(".00");
            labelBTW.Text = "€ " + prijsBTW.ToString(".00");
            labelTotaalPrijs.Text ="€ " + prijsTotaal.ToString(".00");


        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
