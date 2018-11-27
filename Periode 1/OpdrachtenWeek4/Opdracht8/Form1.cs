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

        private void btnVergelijkFormules_Click(object sender, EventArgs e)
        {

            // declaratie
            int getalN;
            double uitkomstF1, uitkomstF2;  // F = formule
            string messageVergelijking;


            // invoer
            getalN = int.Parse(txtInvoer.Text);
            // initiële waarde uitkomstf1
            uitkomstF1 = getalN;
            // waarde uitkomstf2
            uitkomstF2 = getalN * (getalN + 1) / 2;

            // for loop die de waarde van uitkomstf1 vergoot met de index tot hij bij het getal N komt
            for (int index = 0; index < getalN; index++)
            {
                uitkomstF1 = uitkomstF1 + index;
            }

            // kleine test op som en formule gelijkheid 
            // Niet echt nodig want als je het goed doet is het altijd gelijk.
            // behalve N < 0
            if (uitkomstF1 == uitkomstF2)
            {
                messageVergelijking = "De som en formule zijn gelijk";
            }
            else
            {
                messageVergelijking = "De som en formule zijn niet gelijk";
            }


            //output
            lblUitkomstF1.Text = uitkomstF1.ToString();
            lblUitkomstF2.Text = uitkomstF2.ToString();
            lblMessageVergelijking.Text = messageVergelijking;
        }
    }
}
