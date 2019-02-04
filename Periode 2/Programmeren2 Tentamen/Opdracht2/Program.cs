using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        const int RIJEN = 6, KOLOMMEN = 10, MIN_WAARDE = 1, MAX_WAARDE = 100;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            int[,] matrix = new int[RIJEN, KOLOMMEN];
            VulMatrix(matrix);
            SorteerMatrix(matrix);
            ToonMatrix(matrix);
            Console.ReadKey();
        }

        void SorteerRij(int[,]matrix, int rij)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                int laagsteIndex = matrix[rij, k];
                for (int l = k+1; l < matrix.GetLength(1)-2; l++)
                {
                    if (matrix[rij,l] < laagsteIndex)
                    {
                        laagsteIndex = matrix[rij, l];
                    }
                    
                }
            }
        }

        void SorteerMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                SorteerRij(matrix, r);
            }
        }

        void VulMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[r, k] = rnd.Next(MIN_WAARDE, MAX_WAARDE);
                }
            }
        }
        void ToonMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[r,k] < 20)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (matrix[r,k] < 40)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (matrix[r,k] < 60)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (matrix[r,k] < 80)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (matrix[r,k] < 100)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    Console.Write("{0:00} ",matrix[r, k]);
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        void SorteerKolom(int[,] matrix, int kolom)
        {

        }
    }
}
