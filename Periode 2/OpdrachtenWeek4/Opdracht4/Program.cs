using System;
using System.Drawing;
using System.IO;

namespace Opdracht3
{
    class Program
    {
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            RegularCandies[,] speelveld = new RegularCandies[9, 9];
            string bestand;
            Console.Write("Voer uw bestand in (Geef nieuwe naam op als u een nieuw bestand wilt) VERGEET NIET .txt: ");
            bestand = Console.ReadLine();
            if (File.Exists(bestand))
            {
                try
                {                    
                    speelveld = LeesSpeelveld(bestand);
                    Console.WriteLine("Spel succesvol geladen");
                }
                catch 
                {   
                    Console.WriteLine("Corrupt gamefile '{0}'. Bestand is overschreven met nieuwe gegevens.", bestand);
                    InitCandies(speelveld);
                    // error, file wordt ergens anders gebruikt.
                    SchrijfSpeelveld(speelveld, bestand);
                }
                
            }
            else
            {
                Console.WriteLine("Nieuw spel aangemaakt voor {0}", bestand);
                InitCandies(speelveld);
                SchrijfSpeelveld(speelveld, bestand);
            }

            PrintCandies(speelveld);
            if (ScoreRijAanwezig(speelveld))
            {
                Console.WriteLine("Ja, er is een score rij aanwezig");
            }
            else
            {
                Console.WriteLine("Nee, er is geen score rij aanwezig");
            }

            if (ScoreKolomAanwezig(speelveld))
            {
                Console.WriteLine("Ja, er is een score kolom aanwezig");
            }
            else
            {
                Console.WriteLine("Nee, er is geen score kolom aanwezig");
            }
            Console.ReadKey();
        }

        void InitCandies(RegularCandies[,] candies)
        {
            for (int r = 0; r < candies.GetLength(0); r++)
            {
                for (int k = 0; k < candies.GetLength(1); k++)
                {
                    candies[r, k] = (RegularCandies)rnd.Next(1, 7);
                }
            }
        }

        void PrintCandies(RegularCandies[,] candies)
        {
            char tag = '#';

            for (int r = 0; r < candies.GetLength(0); r++)
            {
                for (int k = 0; k < candies.GetLength(1); k++)
                {
                    switch (candies[r, k])
                    {
                        case RegularCandies.Jellybean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case RegularCandies.Gum_Square:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case RegularCandies.Jujube_Cluster:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;
                       
                    }

                    Console.Write("{0} ", tag);
                    
                    
                    if (k + 1 == candies.GetLength(1))
                    {
                        k = 0;
                        Console.WriteLine();
                        break;
                    }
                }
            }
            Console.ResetColor();
        }

        bool ScoreRijAanwezig(RegularCandies[,] candies)
        {
            // Standaard benodigde waardes
            int teller = 1;

            for (int r = 0; r < candies.GetLength(0); r++)
            {
                for (int k = 0; k < candies.GetLength(1); k++)
                {

                    if (k+1 < candies.GetLength(1)  && candies[r, k] == candies[r, k + 1])
                    {
                        teller++;
                        if (teller >= 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        teller = 1;
                    }
                }
            }
            return false;
        }


        bool ScoreKolomAanwezig(RegularCandies[,] candies)
        {
            int teller = 1;
            

            for (int r = 0; r < candies.GetLength(0); r++)
            {
                for (int k = 0; k < candies.GetLength(1); k++)
                {
                    if (r+1 < candies.GetLength(0) && candies[r,k] == candies[r+1,k])
                    {
                        teller++;
                        r++;

                        if (r + 1 < candies.GetLength(0) && candies[r, k] == candies[r + 1, k])
                        {
                            teller++;
                        }
                        else
                        {
                            r--;
                            teller = 1;
                        }
                        if (teller >= 3)
                        {
                            return true;
                        }

                    }
                }
            }
            return false;
        }

        void SchrijfSpeelveld(RegularCandies[,] speelveld, string bestandsnaam)
        {
            StreamWriter writer = new StreamWriter(bestandsnaam);
            for (int r = 0; r < speelveld.GetLength(0); r++)
            {
                for (int k = 0; k < speelveld.GetLength(1); k++)
                {
                    writer.Write((int)speelveld[r,k] + " ");
                }
                writer.WriteLine();

            }
            writer.Close();
        }
        RegularCandies[,] LeesSpeelveld(string bestandsnaam)
        {
            RegularCandies[,] speelveld = new RegularCandies[9, 9];
            StreamReader reader = new StreamReader(bestandsnaam);
            // Als het niet lukt moet de reader ook gesloten worden anders kunnen we niet overschrijven.
            try
            {
                for (int r = 0; r < speelveld.GetLength(0); r++)
                {
                    string regel = reader.ReadLine();
                    string[] getalStrings = regel.Split(' ');
                    for (int k = 0; k < speelveld.GetLength(1); k++)
                    {
                        speelveld[r, k] = (RegularCandies)int.Parse(getalStrings[k]);
                    }
                }
                reader.Close();
                return speelveld;
            }
            catch (Exception)
            {
                reader.Close();
                throw;
            }  
        }
       

    }
}
