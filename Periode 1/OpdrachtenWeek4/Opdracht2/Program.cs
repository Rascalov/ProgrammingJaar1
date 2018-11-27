using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int richtGetal, invoerGetal, aantalGelijkeGetallen;

            // standaard waarde toekennen
            aantalGelijkeGetallen = 0;
            // invoer richtgetal
            Console.Write("Geef het richtgetal: ");
            richtGetal = Convert.ToInt32(Console.ReadLine());


            // loop tot er 0 wordt ingevoerd
            do
            {
                Console.Write("Voer getal in: ");
                invoerGetal = Convert.ToInt32(Console.ReadLine());

                // condition voor meten aantal getallen gelijk aan richtgetal
                if (invoerGetal == richtGetal)
                {
                    aantalGelijkeGetallen++;
                }
            }
            // loop condition
            while (invoerGetal != 0);

            //output
            Console.WriteLine("Het aantal getallen dat gelijk is aan het richtgetal is: {0}", aantalGelijkeGetallen);
            Console.ReadKey();

        }
    }
}
