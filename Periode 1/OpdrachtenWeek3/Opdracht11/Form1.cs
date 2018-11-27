using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int getal1, getal2, grootsteGetal;
        private double gemiddelde, verschil;


        private void button1_Click(object sender, EventArgs e)
        {
            getal1 = int.Parse(txtGetal1.Text);
            getal2 = int.Parse(txtGetal2.Text);


            if (getal1 > getal2)
            {
                grootsteGetal = getal1;
                
            }
            else
            {
                grootsteGetal = getal2;
                
            }

            gemiddelde = (getal1 + getal2) / 2.0;
            verschil = grootsteGetal - gemiddelde;


            //output

            lblHoogste.Text = grootsteGetal.ToString();
            lblGemiddelde.Text = gemiddelde.ToString();
            lblVerschil.Text = verschil.ToString();
        }
    }
}
