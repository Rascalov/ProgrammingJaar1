using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            // lees leeftijd gebruiker
            Console.Write("Geef uw leeftijd: ");
            String invoer = Console.ReadLine();

            //convert string naar int
            int leeftijd = int.Parse(invoer);


            // we kunnen nu rekenen met de convert
            leeftijd = leeftijd +=1;


            // Convert integer naar string
            string uitvoer = leeftijd.ToString();

            // schrijft verhoogde leeftijd naar scherm
            Console.Write("Volgend jaar bent u " + uitvoer + " jaar oud.");

            Console.ReadLine();
        }
    }
}
