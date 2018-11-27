using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // declaratie
        private double salarisHuidig, loonsVerhoging, salarisNieuw;
        private const double PERCENTAGE_LOONSVERHOGING = 0.05;
        private const double MINIMUM_LOONSVERHOGING = 75.00;
        private void button1_Click(object sender, EventArgs e)
        {

            // invoer
            salarisHuidig = double.Parse(txtSalaris.Text);

            // verhoging met controle op de minimum verhoging.
            loonsVerhoging = salarisHuidig * PERCENTAGE_LOONSVERHOGING;
            if (loonsVerhoging < MINIMUM_LOONSVERHOGING)
            {
                loonsVerhoging = MINIMUM_LOONSVERHOGING;
            }

            salarisNieuw = salarisHuidig + loonsVerhoging;

            //output

            lblVerhoging.Text = "€" + loonsVerhoging.ToString("0.00");
            lblNieuweSalaris.Text = "€" +  salarisNieuw.ToString("0.00");

        }
    }
}
