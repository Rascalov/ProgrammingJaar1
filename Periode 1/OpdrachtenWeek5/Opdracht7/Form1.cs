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

        private void btnGooien_Click(object sender, EventArgs e)
        {
            // declaratie
            Random rnd = new Random();
            int getal;
            string resultaat = "";
            string nummer;

            // array voor de dobbelsteen, opzich niet nodig om 6x 0 in te voeren kan ook met = new int[6]
            int[] dobbelsteen = new int[] { 0, 0, 0, 0, 0, 0 };

            //loop tot 6000
            for (int i = 0; i < 6000; i++)
            {
                // dobbelsteen simulatie
                getal = rnd.Next(1, 7);
                dobbelsteen[getal - 1]++; // = dobbelsteen[getal - 1] + 1;
                /*
                // cases voor de zes gevallen, per geval krijgt de toepasselijke int in de array + 1; 
                switch (getal)
                {
                    case 1:
                        dobbelsteen[0] = dobbelsteen[0] + 1;
                        break;
                    case 2:
                        dobbelsteen[1] = dobbelsteen[1] + 1;
                        break;
                    case 3:
                        dobbelsteen[2] = dobbelsteen[2] + 1;
                        break;
                    case 4:
                        dobbelsteen[3] = dobbelsteen[3] + 1;
                        break;
                    case 5:
                        dobbelsteen[4] = dobbelsteen[4] + 1;
                        break;
                    case 6:
                        dobbelsteen[5] = dobbelsteen[5] + 1;
                        break;

                }*/

            }
            for (int i = 0; i < dobbelsteen.Length; i++)
            {
                // + 1 zorgt ervoor dat het dobbelsteen 1, 2, 3, etc wordt ipv 0, 1 , 2
                nummer = (i + 1).ToString();
                resultaat = resultaat + "\n" + "Waarde " + nummer + " is " + dobbelsteen[i] + " keer gegooid ";
            }


            //output in 1 label
            lblWaardes.Text = resultaat;
        }
    }
}
