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

        private void btnBereken_Click(object sender, EventArgs e)
        {
            double getal = double.Parse(txtInvoer.Text);

            if (rdCelNaarKel.Checked)
            {
                lblUitkomst.Text = CelNaarKel(getal).ToString("0.00");
            }
            else if (rdCelNaarFah.Checked)
            {
                lblUitkomst.Text = CelNaarFahr(getal).ToString("0.00");
            }
            else if (rdFahNaarCel.Checked)
            {
                lblUitkomst.Text = FahrNaarCel(getal).ToString("0.00");
            }
            
            else
            {
                // realiseerde later dat radio buttons een default keuze hebben >.> 
                lblUitkomst.Text = "Geen conversie aangegeven";
            }
        }

        double CelNaarKel(double getal)
        {
            return getal + 273;
        }
        double CelNaarFahr(double getal)
        {
            return getal * 9 / 5 + 32;
        }
        double FahrNaarCel(double getal)
        {
            return (getal - 32) * 5 / 9;
        }
    }
}
