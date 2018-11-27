using System;

namespace Opdracht1
{
    class Program
    {
        const float BTW = 0.21F;
        static void Main(string[] args)
        {
            float prijs, btwPrijs ,totaalPrijs;
             
            Console.Write("Enter a price: ");
            prijs = float.Parse(Console.ReadLine());

            // berekenen via de methodes
            btwPrijs = BerekenBtwWaarde(prijs);
            totaalPrijs = BerekenBtw(prijs);
            

            Console.WriteLine("price: {0:0.00}, VAT: {1:0.00}, total: {2:0.00}", prijs, btwPrijs, totaalPrijs);


            Console.ReadKey();
        }


        // method voor prijs met btw
        static float BerekenBtw(float prijs)
        {

            float btwPrijs = BerekenBtwWaarde(prijs);
            float totaalPrijs = prijs + btwPrijs;


            return totaalPrijs;
           
        }
        // method voor berekenen btwWaarde
        static float BerekenBtwWaarde(float prijs)
        {
            return  prijs * BTW;
        }
    }
}
