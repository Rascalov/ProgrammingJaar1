using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie en toekenning
            Random rnd = new Random();
            int faculteitgetal = rnd.Next(0, 10);

            // loop tot 0
            while (faculteitgetal != 0)
            {
                Console.WriteLine("faculteit van {0} is {1}", faculteitgetal, Faculteit(faculteitgetal));
                faculteitgetal = rnd.Next(0, 10);
            }
            // eind tekst en loop
            Console.WriteLine();
            Console.WriteLine("einde programma");
            Console.ReadKey();
        }

        static int Faculteit(int getal)
        {
            // bepaal de faculteit
            // door alle getallen tot en met het facuGetal met elkaar te vermenigvuldigen.
            int uikomstFacu = 1;
            for (int i = 1; i <= getal; i++)
            {
                uikomstFacu = uikomstFacu * i;
            }
            return uikomstFacu;
        }
    }

}
