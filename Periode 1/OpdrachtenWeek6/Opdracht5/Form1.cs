using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int getal1;
        private int getal2;

        // per Button: declaratie, bijbehorende methode en output.

        private void btnPlus_Click(object sender, EventArgs e)
        {
            getal1 = int.Parse(txtInvoer1.Text);
            getal2 = int.Parse(txtInvoer2.Text);
            Plus(getal1, getal2);
            lblUitkomst.Text = Plus(getal1, getal2).ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            getal1 = int.Parse(txtInvoer1.Text);
            getal2 = int.Parse(txtInvoer2.Text);
            lblUitkomst.Text = Min(getal1, getal2).ToString();
        }

        private void btnKeer_Click(object sender, EventArgs e)
        {
            getal1 = int.Parse(txtInvoer1.Text);
            getal2 = int.Parse(txtInvoer2.Text);
            lblUitkomst.Text = Keer(getal1, getal2).ToString();
        }

        private void btnDelen_Click(object sender, EventArgs e)
        {
            getal1 = int.Parse(txtInvoer1.Text);
            getal2 = int.Parse(txtInvoer2.Text);
            lblUitkomst.Text = Delen(getal1, getal2).ToString("0.00");
        }


        private int Plus(int getal1, int getal2)
        {
            return getal1 + getal2; 
        }
        private int Min(int getal1, int getal2)
        {
            return getal1 - getal2;
        }
        private int Keer(int getal1, int getal2)
        {
            return getal1 * getal2;
        }
        private double Delen(int getal1, int getal2)
        { 
            return (double) getal1 / (double) getal2;
        }
    }
}
