using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const double GELDVOETBAL = 175.00;
        private const double GELDVOLLEYBAL = 225.00;
        private const double OUD_LID_KORTING = 25.00;
        private const double LANG_LID_KORTING = 20.00;



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kosten, standaardVerenigingKosten;
            double korting = 0;
            int leeftijd, lidJaren;

            // bepaling waarde van verenigingKosten 
            if (radiobtnVoetbal.Checked)
            {
                standaardVerenigingKosten = GELDVOETBAL;
            }
            else
            {
                standaardVerenigingKosten = GELDVOLLEYBAL;
            }
            leeftijd = int.Parse(txtLeeftijd.Text);
            lidJaren = int.Parse(txtLidJaren.Text);



            // korting conditions
            if (leeftijd > 40)
            {
                korting = korting + OUD_LID_KORTING;
            }
           
            if (lidJaren > 10)
            {
                korting = korting + LANG_LID_KORTING;
            }
          
            kosten = standaardVerenigingKosten - korting;

            lblKosten.Text = "€" + kosten.ToString("0.00");

            // reset korting voor verdere berekeningen
            korting = 0;



        }
    }
}
