using System;
using System.Drawing;

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
            RegularCandies[,] speelveld = new RegularCandies[9,9];

            InitCandies(speelveld);
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



       

    }
}
