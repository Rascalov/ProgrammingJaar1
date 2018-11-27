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

        private void btnBereken_Click(object sender, EventArgs e)
        {

            double uren, km, kmPerUur;
            km = 0;
            if (rdbtn5Km.Checked)
            {
                km = 5;
            }
            else if (rdbtn10Km.Checked)
            {
                km = 10;
            }
            else if (rdbtn21Km.Checked)
            {
                km = 21;
            }
            
            uren = double.Parse(txtUren.Text) + (double.Parse(txtMinuten.Text) / 60) + (double.Parse(txtSeconden.Text) / 3600);

            kmPerUur = km / uren;
            lblKmPerUur.Text = kmPerUur.ToString("0.000");
        }
    }
}
