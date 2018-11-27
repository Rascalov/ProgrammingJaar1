using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int getal, totaal, nummerBijhouden;

            // standaard waardes
            nummerBijhouden = 0;
            totaal = 0;

            // loop tot er 0 wordt ingevoerd
            do
            {
                Console.Write("Voer getal in: ");
                getal = Convert.ToInt32(Console.ReadLine());
                
                // Houdt bij welk nummer 
                nummerBijhouden++;

                if (nummerBijhouden == 5)
                {
                    totaal = totaal + getal;
                    nummerBijhouden = 0;
                }

            }


            while (getal != 0);

            //ouput 
            Console.WriteLine("De som van het 5-de, 10-de, 15-de, ... getal is: {0}", totaal);
            Console.ReadKey();
        }
    }
}
