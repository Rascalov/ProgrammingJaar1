using System;

namespace Opdracht2
{
    class Program
    {
        // constante 
        const int aantalGetallen = 3;

        static void Main(string[] args)
        {
            double getal1, getal2, getal3, getalGemmidelde;
            
            
            
            Console.Write("Geeft getal1: ");
            // input convert naar de int waarde voor getal 1 t/m 3.
            getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geeft getal2: ");
            getal2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geeft getal3: ");
            getal3 = Convert.ToDouble(Console.ReadLine());

            // waarde berekenen en toekennen.
            getalGemmidelde = (getal1 + getal2 + getal3) / aantalGetallen;

            // output
            Console.Write("gemiddelde: {0} ", getalGemmidelde);

            // loop
            Console.ReadLine();
        }
    }
}
