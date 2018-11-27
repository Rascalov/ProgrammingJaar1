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
        public Form1()
        {
            InitializeComponent();
        }
        private int getal;

        private void btnKwadraad1_Click(object sender, EventArgs e)
        {
            getal = int.Parse(txtInvoer.Text);
            KwadraatByReference(ref getal);
            lblUitkomst.Text = getal.ToString();

        }

        private void btnKwadraad2_Click(object sender, EventArgs e)
        {
            getal = int.Parse(txtInvoer.Text);
            int kwadraat;
            KwadraatByReferenceOut(getal, out kwadraat);
            lblUitkomst.Text = kwadraat.ToString();

        }

        private void btnKwadraad3_Click(object sender, EventArgs e)
        {
            getal = int.Parse(txtInvoer.Text);
            lblUitkomst.Text = KwadraatByValue(getal).ToString();
        }

        void KwadraatByReference(ref int getal)
        {   
            getal = getal * getal;
        }
        void KwadraatByReferenceOut(int getal, out int kwadraat)
        {
            kwadraat = getal * getal;
        }
        int KwadraatByValue(int getal)
        {
            return getal * getal;
        }

        // pass by reference verandert de echte versie van de variabel met een waarde
        // pass by value neemt een kopie van die variabel en geeft het een waarde
    }
}
