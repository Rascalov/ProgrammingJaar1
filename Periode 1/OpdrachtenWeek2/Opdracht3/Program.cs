using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondenInvoer, uren, minuten, seconden;

            Console.Write("Geef aantal seconden: ");
            secondenInvoer = Convert.ToInt32(Console.ReadLine());
            // bereken aantal uren
            uren = secondenInvoer / 3600;
            // haalt aantal uren van de invoer af 
            secondenInvoer = secondenInvoer - (uren * 3600); // %
            // bereken aantal minuten
            minuten = secondenInvoer / 60;
            // haal aantal minuten van de invoer af
            secondenInvoer = secondenInvoer - (minuten * 60);
            // overige seconden staan gelijk aan variabel "seconden" 
            seconden = secondenInvoer;
            // schrijft de waardes in gevraagde format hh:mm:ss
            Console.WriteLine("{0:00}:{1:00}:{2:00}", uren, minuten, seconden);

            
            // loop
            Console.ReadLine();

        }
    }
}
