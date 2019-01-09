using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchuifMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            int[,] matrix = new int[5, 10];
            Vulmatrix(matrix);
            ToonMatrix(matrix);
            Console.WriteLine();
            Console.Write("Geef een getal: ");
            int zoekgetal = int.Parse(Console.ReadLine());
            VershuifMatrix(matrix, zoekgetal);
            ToonMatrix(matrix);
            Console.ReadKey();
        }

        void Vulmatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[r, k] = rnd.Next(1,100);
                }
            }
        }
        void ToonMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0:00} ", matrix[r, k]);
                }
                Console.WriteLine();
            }
        }
        void VershuifMatrix(int[,] matrix, int zoekgetal)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[r,k] == zoekgetal)
                    {
                        VerschuifRij(matrix, r, k );
                        Console.WriteLine();
                        Console.WriteLine($"Rij {r} vershuiven vanaf kolom {k}");

                        
                        break;
                    }
                }
            }
        }
        void VerschuifRij(int[,] matrix, int rij, int kolom)
        {
            int[] temp = new int[matrix.GetLength(1)];

            for (int i = 0; i < temp.Length; i++)
            {
                
                temp[i] = matrix[rij, kolom];
                
                kolom++;
                if (kolom > matrix.GetLength(1)-1)
                {
                    kolom = 0;
                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[rij, i] = temp[i];
            }
        }
    }
}
