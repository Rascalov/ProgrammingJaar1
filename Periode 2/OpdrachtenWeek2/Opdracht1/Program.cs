using System;

namespace Opdracht1
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
            Console.Write("rijen en kolommen: ");
            int mat = int.Parse(Console.ReadLine());
            
            int[,] matrixDing = new int[mat,mat];

            InitMatrixLineair(matrixDing);

        //    InitMateix2D(matrixDing);
            PrintMatrixWithCross(matrixDing);
            Console.ReadKey();

        }

        void InitMateix2D(int[,] matrix)
        {
            // om het simpeler voor me te houden schreef ik de getlength waardes in variabelen, na deze begreep ik het wel.
            int aantalRijen = matrix.GetLength(0);
            int aantalKolommen = matrix.GetLength(1);
            int getal = 1;
           
            for (int r = 0; r < aantalRijen; r++)
            {

                for (int k = 0; k < aantalKolommen; k++)
                {
                    matrix[r, k] = getal;
                    getal++;

                 
                }

            }
        }


        void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write("{0,3} ",   matrix[r, k]);

                    if (k+1 == matrix.GetLength(1))
                    {
                        k = 0;
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }

        void InitMatrixLineair(int[,] matrix)
        {
            int hokjes, lengteRij, lengteKolom, getalR, getalK;
            lengteRij = matrix.GetLength(0);
            lengteKolom = matrix.GetLength(1);
            hokjes = lengteRij * lengteKolom; 

            // bepaal met 1 getal waar hij in de rij en kolom moet staan
            // vb. 1 = 0.0
            int getal = 1;
            //int locatie = getal/matrix.GetLength(1);

            for (int i = 0; i < hokjes; i++)
            {

                matrix[(getal -1) / matrix.GetLength(1), (getal -1) % matrix.GetLength(0)] = getal;
                getal++;
              

            }


            /*
            getalR = 0;
            getalK = 0;

            for (int getal = 1; getal <= hokjes; getal++)
            {
                matrix[getalR,getalK] = getal;

                getalK++;
                if (getalK == lengteKolom)
                {
                    getalR++;
                    getalK = 0;
                }
                
            } */
        }

        void PrintMatrixWithCross(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (k == r)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                  
                    if (k == matrix.GetLength(1) - (r+1)) 
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        
                    }

                    Console.Write("{0,3} ", matrix[r, k]);
                    Console.ResetColor();
                    if (k + 1 == matrix.GetLength(1))
                    {
                        k = 0;
                        Console.WriteLine();
                        break;
                    }
                    
                }
                
            }
        }
    }


}
