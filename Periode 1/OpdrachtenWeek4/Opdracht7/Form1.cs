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

        private void btnMaakVierkant_Click(object sender, EventArgs e)
        {
            //declaratie
            int aantalZijdes;
            string text;

            // Begin waarde en reset de waarde op iedere druk voor een nieuwe invoer
            text = "";
            // invoer waarde
            aantalZijdes = int.Parse(txtZijdes.Text);
            
            // loop met 1 nestled for loop
            // maakt de aantalzijdes
            for (int rijen = 1; rijen <= aantalZijdes; rijen++)
            {
                // maakt 1 rij van het ingevoerde aantal
                for (int i = 1; i <= aantalZijdes; i++)
                {
                    
                    // deze set van conditions geven aan wanneer hij spaties moet geven.
                    // als de rij niet gelijk staat aan de eerste en de laatste rij.
                    // En als de rij niet gelijk staat aan de bodem (laatste rij)
                    
                    if (rijen > 1 && i < aantalZijdes && rijen != aantalZijdes && i > 1)
                    {
                        text = text + " ";
                    }
                    else
                    {
                        text = text + "X";
                    }
                    
                    
                }
                



                // na iedere iteratie (na iedere rij), regel naar beneden
                text = text + "\n";
                
            }
           
            // output
            lblX.Text = text;
        }
    }
}
