using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {   // Hier wordt variable "naam" gedeclareerd
            // deze variabel wordt hierna gebruikt
            String naam;

            Console.WriteLine("Wat is uw Naam? ");
            // Lees de naam van de gebruiker en sla deze op in variable "naam"
            naam = Console.ReadLine();

            // Lees de leeftijd van de gebruiker en sla deze op in variabele "Leeftijd"
            // variabele wordt hier ook gedeclareerd
            Console.WriteLine("Prachtige naam, hoe oud bent u? ");
            String leeftijd = Console.ReadLine();

            // Output met gegevens
            Console.WriteLine("Uw naam is " + naam + ".");
            Console.WriteLine("U bent " + leeftijd + " jaar oud.");



            Console.ReadLine();
        }
    }
}
