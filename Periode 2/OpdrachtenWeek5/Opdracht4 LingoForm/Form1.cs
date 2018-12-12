using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4_LingoForm
{

     
    public partial class Form1 : Form
    {
        int Pogingen = 5;
        SoundPlayer Correct = new SoundPlayer("Correct.wav");
        SoundPlayer Incorrect = new SoundPlayer("Incorrect.wav");
        SoundPlayer WrongPostion = new SoundPlayer("Verkeerd.wav");
        LingoGame lingo = new LingoGame();
        int r = 0;
        Random rnd = new Random();
        public Form1()
        {

            InitializeComponent();

            lingo.lingoWoord = ChooseWord(ReadWords("woorden.txt"));
            label1.Text = lingo.lingoWoord;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button[,] Buttons = new Button[,] {
                { Rij0Btn0, Rij0Btn1, Rij0Btn2, Rij0Btn3, Rij0Btn4 },
                { Rij1Btn0, Rij1Btn1, Rij1Btn2, Rij1Btn3, Rij1Btn4 },
                { Rij2Btn0, Rij2Btn1, Rij2Btn2, Rij2Btn3, Rij2Btn4 },
                { Rij3Btn0, Rij3Btn1, Rij3Btn2, Rij3Btn3, Rij3Btn4 },
                { Rij4Btn0, Rij4Btn1, Rij4Btn2, Rij4Btn3, Rij4Btn4 }
            };

            lingo.playerWoord = ReadPlayerWord(5);

            DisplayResults(lingo.playerWoord, lingo.EvaluateWord(lingo.playerWoord, lingo.lingoWoord), Buttons);
            Pogingen--;
            if (lingo.IsGuessed())
            {
                MessageBox.Show("LINGO, GOED GEDAAN!");
                Resetgame(Buttons);
            }
            else if (Pogingen == 0)
            {

                MessageBox.Show($"Jammer, het woord was {lingo.lingoWoord}!");
                Resetgame(Buttons);
            }
            
        }
        void Resetgame(Button[,] Buttons)
        {
            foreach (Button b in Buttons)
            {
                b.ResetText();
                b.BackColor = default(Color);
                b.UseVisualStyleBackColor = true;
            }
            Pogingen = 5;
            r = 0;
            lingo.lingoWoord = ChooseWord(ReadWords("woorden.txt"));
            label1.Text = lingo.lingoWoord;

        }

        void SpeelGeluidAf(States status)
        {
            
            switch (status)
            {
                case States.Correct:
                    Correct.Play();
                    break;
                case States.Incorrect:
                    Incorrect.Play();
                    break;
                case States.WrongPosition:
                    WrongPostion.Play();
                    break;
            }

            
        }

        void DisplayResults(string playerword, States[] results, Button[,] Buttons)
        {
            for (int k = 0; k < Buttons.GetLength(1); k++)
            {

                if (results[k] == States.Correct)
                {
                    Buttons[r, k].BackColor = Color.Red;
                }
                else if (results[k] == States.WrongPosition)
                {
                    Buttons[r, k].BackColor = Color.Yellow;
                }

                Buttons[r, k].Text = playerword[k].ToString().ToUpper();
                Buttons[r, k].Refresh();
                SpeelGeluidAf(results[k]);
                Thread.Sleep(250);
            }
            r++;
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

            try
            {
                woord = txtInvoer.Text;
                if (woord.Length != 5)
                {
                    return null;
                }
                return woord;
            }
            catch (Exception)
            {
                label1.Text = "Woord is heeft geen lengte van 5!";
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
