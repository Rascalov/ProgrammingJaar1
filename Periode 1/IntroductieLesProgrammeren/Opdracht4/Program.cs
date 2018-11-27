using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_LEEFTIJD = 65;
            int leeftijd;

            Console.Write("Voer je leeftijd in: ");
            // convert om readline te kunnen gebruiken voor integers.
            leeftijd = Convert.ToInt32(Console.ReadLine());
            bool teOud;
            teOud = (leeftijd >= MAX_LEEFTIJD);
            Console.WriteLine("waarde van teOud: {0}", teOud);
            // wacht totdat de gebruiker een toets indrukt
            Console.ReadKey();
        }
    }
}
