using System;

namespace Opdracht0
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            int getal = LeesInt("tik een getal: ");
            Console.WriteLine("Je hebt {0} ingetikt", getal);

            int leeftijd = LeesInt("hoe oud ben je? ", 0, 120);

            string naam = LeesString("Hoe heet je? ");
            Console.WriteLine("Aangenaam kennis met je te maken, {0}.", naam);

            Console.ReadKey();
        }

        // Deze methode leest een integer en geeft die waarde terug.
        int LeesInt(string vraag)
        {
            int invoer;
            Console.Write(vraag);
            invoer = int.Parse(Console.ReadLine());
            return invoer;
        }
        // Deze methode krijgt een invoer binnen en als het tussen de gegeven waardes ligt gaat het programma door, zo niet loopt hij. 
        int LeesInt(string vraag, int min, int max)
        {
            int invoer;

            do
            {
                invoer = LeesInt(vraag);
            } while (invoer > max || invoer < min);
            return invoer;
        }
        // Deze methode leest een string in.
        string LeesString(string vraag)
        {
            string invoer;
            Console.Write(vraag);
            invoer = Console.ReadLine();
            return invoer;
        }
    }
}
