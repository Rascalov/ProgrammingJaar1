using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // declaratie
        private const double STANDAARD_PRIJS = 12.00;
        private int leeftijd;
        private double prijsBios;

        private void button1_Click(object sender, EventArgs e)
        {
            // invoer
            leeftijd = int.Parse(txtLeeftijd.Text);
            // bepaling korting
            if (leeftijd < 5 || leeftijd >= 55)
            {
                prijsBios = 0;
            }
            else if (leeftijd <= 12 && leeftijd >= 5)
            {
                prijsBios = STANDAARD_PRIJS / 2.0;
            }
            else
            {
                prijsBios = STANDAARD_PRIJS;
            }


            // output
            lblPrijsTicket.Text = "€ " + prijsBios.ToString("0.00");
        }
    }
}
