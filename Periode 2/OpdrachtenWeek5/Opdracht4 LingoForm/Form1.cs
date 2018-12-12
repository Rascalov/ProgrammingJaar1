using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4_LingoForm
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseWord(ReadWords("woorden.txt"));
            
        }
        void DisplayResults(string playerword,States[] results)
        {
            for (int r = 0; r < playerword.Length; r++)
            {
                for (int k = 0; k < playerword.Length; k++)
                {
                    int buttonRij = r;
                    int buttonKolom = k;
                    var huidigeButton = $"Rij{r}Btn{k}";
                    
                    
                }
            }
        }
        List<string> ReadWords(string file)
        {
            List<string> woordenlijst = new List<string>();
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string woord = reader.ReadLine();
                if (woord.Length == 5)
                {
                    woordenlijst.Add(woord);
                }
            }
            return woordenlijst;
        }
        string ChooseWord(List<string> woordenlijst)
        {
            return (woordenlijst[rnd.Next(0, woordenlijst.Count)]);
        }
        string ReadPlayerWord(int lengte)
        {
            string woord;

            woord = txtInvoer.Text;
            if (woord.Length != 5)
            {
                label1.Text = "Woord is niet 5 letters lang!";
            }

            return woord;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
