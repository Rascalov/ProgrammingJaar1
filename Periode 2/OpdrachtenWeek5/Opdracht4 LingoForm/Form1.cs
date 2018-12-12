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

        
        
        int rij = 0;
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
            Button[] buttonsRij0 = new Button[] { Rij0Btn0, Rij0Btn1, Rij0Btn2, Rij0Btn3, Rij0Btn4 };
            Button[] buttonsRij1 = new Button[] { Rij1Btn0, Rij1Btn1, Rij1Btn2, Rij1Btn3, Rij1Btn4 };
            Button[] buttonsRij2 = new Button[] { Rij2Btn0, Rij2Btn1, Rij2Btn2, Rij2Btn3, Rij2Btn4 };
            Button[] buttonsRij3 = new Button[] { Rij3Btn0, Rij3Btn1, Rij3Btn2, Rij3Btn3, Rij3Btn4 };
            Button[] buttonsRij4 = new Button[] { Rij4Btn0, Rij4Btn1, Rij4Btn2, Rij4Btn3, Rij4Btn4 };
            switch (rij)
            {
                // misschien per rij een array van type button en loop per button.text.
                case 0:
                    for (int i = 0; i < playerword.Length; i++)
                    {
                        if (results[i] == States.Correct)
                        {
                            buttonsRij0[i].BackColor = Color.Red;
                             
                        }
                        else if (results[i] == States.WrongPosition)
                        {
                            buttonsRij0[i].BackColor = Color.Yellow;
                        }

                        buttonsRij0[i].Text = playerword[i].ToString();
                    }
                    break;
                case 1:
                    for (int i = 0; i < playerword.Length; i++)
                    {
                        if (results[i] == States.Correct)
                        {
                            buttonsRij1[i].BackColor = Color.Red;

                        }
                        else if (results[i] == States.WrongPosition)
                        {
                            buttonsRij1[i].BackColor = Color.Yellow;
                        }

                        buttonsRij1[i].Text = playerword[i].ToString();
                    }
                    break;
                case 2:
                    for (int i = 0; i < playerword.Length; i++)
                    {
                        if (results[i] == States.Correct)
                        {
                            buttonsRij2[i].BackColor = Color.Red;

                        }
                        else if (results[i] == States.WrongPosition)
                        {
                            buttonsRij2[i].BackColor = Color.Yellow;
                        }

                        buttonsRij2[i].Text = playerword[i].ToString();
                    }
                    break;
                case 3:
                    for (int i = 0; i < playerword.Length; i++)
                    {
                        if (results[i] == States.Correct)
                        {
                            buttonsRij3[i].BackColor = Color.Red;

                        }
                        else if (results[i] == States.WrongPosition)
                        {
                            buttonsRij3[i].BackColor = Color.Yellow;
                        }

                        buttonsRij3[i].Text = playerword[i].ToString();
                    }
                    break;
                case 4:
                    for (int i = 0; i < playerword.Length; i++)
                    {
                        if (results[i] == States.Correct)
                        {
                            buttonsRij4[i].BackColor = Color.Red;

                        }
                        else if (results[i] == States.WrongPosition)
                        {
                            buttonsRij4[i].BackColor = Color.Yellow;
                        }

                        buttonsRij4[i].Text = playerword[i].ToString();
                    }
                    break;

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
