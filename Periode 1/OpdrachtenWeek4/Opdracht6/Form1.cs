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

        const double RENTE_PER_JAAR = 1.05;
        
        private double bedragStart, bedragEind;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnBerekenKapitaal_Click(object sender, EventArgs e)
        {
            bedragStart = double.Parse(txtInvoer.Text);
            for (int jaren = 0; jaren < 5; jaren++)
            {
                bedragEind = bedragStart * RENTE_PER_JAAR;
                bedragStart = bedragEind;
            }

            lblEindKapitaal.Text ="€ " + bedragEind.ToString("0.00");
        }
    }
}
