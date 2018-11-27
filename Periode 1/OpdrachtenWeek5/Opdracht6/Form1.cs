using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht6
{
    public partial class Form1 : Form
    {
        // arrays declareren
        private int[] getallenVoor = new int[20];
        private int[] getallenNa = new int[20];


        public Form1()
        {
            InitializeComponent();
            // rng
            Random rnd = new Random();

            // strings voor formatting in de text
            string elementenVoor = "";
            string elementNr, elementWaarde;

            // loop die de waardes in de array zet
            for (int i = 0; i < getallenVoor.Length; i++)
            {
                getallenVoor[i] = rnd.Next(0, 500);

                // formatting en neerzetten in de string die op het label gaat.
                elementNr = i.ToString("00");
                elementWaarde = getallenVoor[i].ToString();
                elementenVoor = elementenVoor + "\n Element " + elementNr + " = " + elementWaarde;

            }
            // output op het label
            lblInhoudVooraf.Text = elementenVoor;
        }




        private void label2_Click(object sender, EventArgs e)
        {


        }


        // button met vergelijking en tweede array
        private void btnVergelijk_Click(object sender, EventArgs e)
        {
            // zet de button uit
            btnVergelijk.Enabled = false;

            // declaratie
            int getalVergelijking;
            string elementenNa = "";
            string elementNr, elementWaarde;

            //invoer
            getalVergelijking = int.Parse(txtInvoer.Text);

            // per getal in array wordt vergeleken met de invoer
            for (int j = 0; j < getallenNa.Length; j++)
            {
                // conditions
                if (getallenVoor[j] >= getalVergelijking)
                {
                    getallenNa[j] = (getallenVoor[j] + 10);
                }
                else
                {
                    getallenNa[j] = (getallenVoor[j] - 5);
                }

                // formatting en neerzetten in de string die op het label gaat.
                elementNr = j.ToString("00");
                elementWaarde = getallenNa[j].ToString();
                elementenNa = elementenNa + "\n Element " + elementNr + " = " + elementWaarde;
            }
            // output op het label
            lblInhoudAchteraf.Text = elementenNa;
        }
    }
}
