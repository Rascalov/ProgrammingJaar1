using System;

namespace Opdracht1
{
    class Program
    {
        // ...

        static void Main(string[] args)
        {
            // constante btw
            const double BTW = 0.21;
            // declaratie
            double prijsInvoer;
            double btwPrijs;
            double totaalPrijs;
            // invoer
            Console.Write("Geef prijs: ");
            prijsInvoer = Convert.ToDouble(Console.ReadLine());
            // waardes bereken aan hand van invoer
            btwPrijs = prijsInvoer * BTW;
            totaalPrijs = prijsInvoer + btwPrijs;


            // output met formatting
            Console.Write("prijs: {0:0.00}, btw: {1:0.00}, totaal {2:0.00}", prijsInvoer, btwPrijs, totaalPrijs);

            Console.ReadLine();
        }
    }
}
