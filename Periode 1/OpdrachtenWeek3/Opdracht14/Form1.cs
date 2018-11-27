using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double lengte, gewicht, bmi, gezondGewichtMin, gezondGewichtMax, bmiMin, bmiMax;

        private void lblBMINormaleWaardes_Click(object sender, EventArgs e)
        {

        }

        private void bmiGegevens()
        {
            lengte = double.Parse(txtLengte.Text);
            gewicht = double.Parse(txtGewicht.Text);
            bmi = gewicht / Math.Pow((lengte / 100), 2);
        }
        private void printGegevens()
        {
            lblBMI.Text = bmi.ToString("0.0");
            lblBMINormaleWaardes.Text = bmiMin.ToString() + " t/m " + bmiMax.ToString();
            lblGezondGewicht.Text = gezondGewichtMin.ToString("0.0") + " t/m " + gezondGewichtMax.ToString("0.0");
        }
        // vrouw bmi knop
        private void btnVrouw_Click(object sender, EventArgs e)
        {
            bmiGegevens();
            bmiMin = 19;
            bmiMax = 24;
            gezondGewichtMin = bmiMin * Math.Pow((lengte / 100), 2);
            gezondGewichtMax = bmiMax * Math.Pow((lengte / 100), 2);
            printGegevens();


        }

        // man bmi knop
        private void btnMan_Click(object sender, EventArgs e)
        {
            bmiGegevens();
            bmiMin = 20;
            bmiMax = 25;
            gezondGewichtMin = bmiMin * Math.Pow((lengte / 100), 2);
            gezondGewichtMax = bmiMax * Math.Pow((lengte / 100), 2);
            printGegevens();
        }
    }
}
