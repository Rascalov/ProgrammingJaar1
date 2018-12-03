using System;
using System.IO;

namespace Opdracht1
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
            string naam;
            Console.Write("Wat is uw naam? ");
            naam = Console.ReadLine();
            
            if (!File.Exists((naam + ".txt")))
            {
                Console.WriteLine("Welkom nieuweling!");
                SchrijfPersoon(LeesPersoon(), (naam + ".txt"));
                Console.WriteLine("Uw gegevens zijn opgeslagen");
            }
            else
            {
                Console.WriteLine("Wat leuk om u hier weer te zien!");
                Console.WriteLine("Wij hebben de volgende informatie over u:");
                ToonPersoon(LeesPersoon((naam + ".txt")));
            }

          
            Console.ReadKey();
        }
        Persoon LeesPersoon()
        {
            Persoon p = new Persoon();

            p.naam = LeesString("Wat is uw naam? ");
            p.woonplaats = LeesString("Waar woont u? ");
            p.leeftijd = LeesInt("Hoe oud bent u? ");

            return p;
        }

        void ToonPersoon(Persoon p)
        {
            Console.WriteLine("{0,-10}: {1}", "Naam" , p.naam);
            Console.WriteLine("{0,-10}: {1}", "Woonplaats", p.woonplaats);
            Console.WriteLine("{0,-10}: {1}", "Leeftijd", p.leeftijd);
        }
        void SchrijfPersoon(Persoon p, string bestandsnaam)
        {
            StreamWriter writer = new StreamWriter(bestandsnaam);
            writer.WriteLine(p.naam);
            writer.WriteLine(p.woonplaats);
            writer.WriteLine(p.leeftijd);
            writer.Close();
        }

        Persoon LeesPersoon(string bestandsNaam)
        {
            Persoon p = new Persoon();
            StreamReader reader = new StreamReader(bestandsNaam);
            p.naam = reader.ReadLine();
            p.woonplaats = reader.ReadLine();
            p.leeftijd = int.Parse(reader.ReadLine());

            return p;
        }
        // methodes van opdracht 0:

        // Deze methode leest een integer en geeft die waarde terug.
        int LeesInt(string vraag)
        {
            int invoer;
            Console.Write(vraag);
            invoer = int.Parse(Console.ReadLine());
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
