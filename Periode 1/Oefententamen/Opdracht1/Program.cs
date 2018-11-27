using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie en toekenning
            string invoer;
            string paling = "";
            Console.Write("Geef een woord: ");
            invoer = Console.ReadLine();

            // zet de invoer om naar een char array om de karakters één voor één in de paling string te zetten
            char[] invoerKarakters = invoer.ToCharArray();
            for (int i = invoerKarakters.Length -1; i >= 0; i--)
            {
                paling = paling + invoerKarakters[i]; 
            }

            // conditions voor de palindroom
            if (paling == invoer)
            {
                Console.WriteLine("{0} is een palindroom", invoer);
            }

            else
            {
                Console.WriteLine("{0} is geen palindroom", invoer);
            }
            // loop
            Console.ReadKey();

        }
    }
}
