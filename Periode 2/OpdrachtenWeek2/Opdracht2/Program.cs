using System;

namespace Opdracht2
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
            // array
            int[,] matrix = new int[10, 10];
            InitMatrixRandom(matrix, 1, 100);
            PrintMatrix(matrix);

            int zoekgetal;
            Console.Write("Geef zoekgetal: ");
            zoekgetal = int.Parse(Console.ReadLine());

            Console.WriteLine("Zoekgetal {0} komt het eerst voor op posite ({1},{2}) ", zoekgetal, ZoekGetal(matrix, zoekgetal).rij , ZoekGetal(matrix, zoekgetal).kolom);
            Console.WriteLine("Zoekgetal {0} komt het laatst voor op positie ({1},{2}) ", zoekgetal, ZoekGetalAchterwaarts(matrix, zoekgetal).rij, ZoekGetalAchterwaarts(matrix, zoekgetal).kolom);

            Console.ReadKey();
        }

        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            // om het simpeler voor me te houden schreef ik de getlength waardes in variabelen, 
            // na deze begreep ik het wel.
            int aantalRijen = matrix.GetLength(0);
            int aantalKolommen = matrix.GetLength(1);

            // per rij
            for (int r = 0; r < aantalRijen; r++)
            {
                // per kolom
                for (int k = 0; k < aantalKolommen; k++)
                {
                    matrix[r, k] = rnd.Next(min, max);
                }
            }
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0,3} ", matrix[r, k]);

                    if (k + 1 == matrix.GetLength(1))
                    {
                        k = 0;
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
        Positie ZoekGetal(int[,] matrix, int zoekgetal)
        {
            Positie results = new Positie();


            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    // Ieder hokje vergelijken. De eerste coördinaten die kloppen komen in results en wordt ge-returned.
                    if (matrix[r, k] == zoekgetal)
                    {
                        results.rij = r;
                        results.kolom = k;
                        return results;
                    }
                }
            }

            return results;
        }
        Positie ZoekGetalAchterwaarts(int[,] matrix, int zoekgetal)
        {
            // hier gwn de eerste kopiëren en de waardes omdraaien van waar hij moet beginnen. 
            // Doe wel de length - 1 want de array gaat van 0 tot 9 en de length is 10 maar je wilt bij 9 beginnen.
            Positie results = new Positie();
            for (int r = matrix.GetLength(0)-1; r > 0 ; r--)
            {
                for (int k = matrix.GetLength(1)-1; k > 0; k--)
                {
                    // Ieder hokje vergelijken. De eerste coördinaten die kloppen komen in results en wordt ge-returned.
                    if (matrix[r, k] == zoekgetal)
                    {
                        results.rij = r;
                        results.kolom = k;
                        return results;
                    }
                    
                }
                
            }
            return results;
        }
    }
}