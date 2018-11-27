using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_6
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

        private void tijdBerekenen_Click(object sender, EventArgs e)
        {
            int secondenInvoer, uren, minuten, seconden;
            secondenInvoer = int.Parse(textInvoerSeconden.Text);
            uren = secondenInvoer / 3600;
            // haalt aantal uren van de invoer af 
            secondenInvoer = secondenInvoer - (uren * 3600);
            // bereken aantal minuten
            minuten = secondenInvoer / 60;
            // haal aantal minuten van de invoer af
            secondenInvoer = secondenInvoer - (minuten * 60);
            // overige seconden staan gelijk aan variabel "seconden" 
            seconden = secondenInvoer;

            tijdDisplay.Text = uren.ToString("00") + ":" + minuten.ToString("00") + ":" + seconden.ToString("00") ;

        }
    }
}
