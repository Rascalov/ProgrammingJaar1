using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht7
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ButtenBedragen_Click(object sender, EventArgs e)
        {
            double beginKM, eindKM, prijsPerKM, prijsZonderBTW, btwWaarde, btwPrijs, verschilKM, PrijsMetBTW;
            btwWaarde = 0.21;
            beginKM = double.Parse(textBeginKM.Text);
            eindKM = double.Parse(textEindKM.Text);
            prijsPerKM = double.Parse(textPrijsKM.Text);
            verschilKM = eindKM - beginKM;
            prijsZonderBTW = verschilKM * prijsPerKM;
            PrijsMetBTW = verschilKM * prijsPerKM * (1 + btwWaarde);
            btwPrijs = prijsZonderBTW * btwWaarde;


            labelPrijsGeenBTW.Text = prijsZonderBTW.ToString("0.00");
            labelBTW.Text = btwPrijs.ToString("0.00");
            labelPrijsMetBTW.Text = PrijsMetBTW.ToString("0.00");

        }

        private void buttonWissen_Click(object sender, EventArgs e)
        {
            textBeginKM.Text = "";
            textEindKM.Text = "";
            textPrijsKM.Text = "";

            labelPrijsGeenBTW.Text = "";
            labelBTW.Text = "";
            labelPrijsMetBTW.Text = "";
        }
    }
}
