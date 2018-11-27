using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const double HUUR_PER_DAG = 55.00;
        private const double KOSTEN_PER_KM = 0.25;
        private const double KOSTEN_PER_LITER = 2.20;
        private const int GRATIS_KM_PER_DAG = 100;
        private int dagenGehuurd, aantalGratisKms;
        private double aantalKm, aantalLiters, aantalKmTeBetalen, kmPrijs, huurBedragDagen, prijsLiters, huurBedragTotaal;


        private void button1_Click(object sender, EventArgs e)
        {
            dagenGehuurd = int.Parse(txtDagenGehuurd.Text);
            aantalKm = double.Parse(txtAantalKm.Text);
            aantalLiters = double.Parse(txtAantalLiters.Text);

            aantalGratisKms = dagenGehuurd * GRATIS_KM_PER_DAG;
            aantalKmTeBetalen = aantalKm - aantalGratisKms;

            if (aantalKmTeBetalen < 0)
            {
                aantalKmTeBetalen = 0;
            }
            kmPrijs = aantalKmTeBetalen * KOSTEN_PER_KM;
            huurBedragDagen = dagenGehuurd * HUUR_PER_DAG;

            if (checkBoxOpKostenHuurder.Checked)
            {
               prijsLiters = aantalLiters * KOSTEN_PER_LITER;
            }

            else
            {
                prijsLiters = 0;
            }

            huurBedragTotaal = kmPrijs + huurBedragDagen + prijsLiters;


            //output
            lblRentKosten.Text = "€" + huurBedragTotaal.ToString("0.00");
            
        }
    }
}
