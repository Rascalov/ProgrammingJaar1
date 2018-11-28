using System;

namespace Opdracht4
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
            int[,] schaakbord = new int[8, 8];

            InitSchaakbord(schaakbord);
            MogelijkePaardenSprongen(schaakbord, PlaatsPaard(schaakbord));
            ToonSchaakbord(schaakbord);

            Console.ReadKey();

        }
        void InitSchaakbord(int[,] schaakbord)
        {
            for (int r = 0; r < schaakbord.GetLength(0); r++)
            {
                for (int k = 0; k < schaakbord.GetLength(1); k++)
                {
                    schaakbord[r, k] = 0;
                }
            }
        }

        void ToonSchaakbord(int[,] schaakbord)
        {
            for (int r = 0; r < schaakbord.GetLength(0); r++)
            {
                for (int k = 0; k < schaakbord.GetLength(1); k++)
                {
                    switch (schaakbord[r, k])
                    {
                        case 0:
                            Console.Write(". ");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("* ");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("* ");
                            break;
                        
                    }
                    Console.ResetColor();


                    

                    if (k == schaakbord.GetLength(1)-1)
                    {
                        
                        break;
                    }

                }
                Console.WriteLine();
            }
        }

        Positie PlaatsPaard(int[,] schaakbord)
        {
            Positie paardPositie = new Positie();

            paardPositie.rij = rnd.Next(0, schaakbord.GetLength(0));
            paardPositie.kolom = rnd.Next(0, schaakbord.GetLength(1));
            schaakbord[paardPositie.rij, paardPositie.kolom] = 1;

            return paardPositie;
        }

        void MogelijkePaardenSprongen(int[,] schaakbord, Positie positie)
        {
            // Maak alle mogelijke sprongen aan voor X en Y
            int[] MogelijkePositiesX = { 2, 1, -1, -2, -2, -1, 1, 2 };

            int[] MogelijkePositiesY = { 1, 2, 2, 1, -1, -2, -2, -1 };


            for (int i = 0; i < schaakbord.GetLength(0); i++)
            {
                // maak de toekomstige positie aan
                int r = positie.rij + MogelijkePositiesY[i];
                int k = positie.kolom + MogelijkePositiesX[i];

                // check of die positie kan vanaf de start positie, zo ja, dan wordt die plek een geel sterretje (waarde 2)
                // de x en y posities moeten groter zijn dan nul, anders stop je zo een negatief getal als positie in het bord
                if (r >= 0 && k >= 0 &&
                // de x en y mogen niet buiten het bord zijn
                r < schaakbord.GetLength(1) && k < schaakbord.GetLength(0) &&
                // en de positie moet niet bezet zijn
                schaakbord[r, k] == 0)
                {
                    // zet de waarde van die plek naar 2, want dan wordt hij bij het opzetten een geel sterretje
                    schaakbord[r, k] = 2;
                }
            }
           
        }


    }
}
