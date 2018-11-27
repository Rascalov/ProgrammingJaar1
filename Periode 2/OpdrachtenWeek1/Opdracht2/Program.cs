using System;

namespace Opdracht2
{
    class Program
    {
        public Persoon[] Personen = new Persoon[3];
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            // voorbeeld struct 
            Persoon Mens;
            Mens.Voornaam = "Tim";
            Mens.Achternaam = "Sanou";
            Mens.Leeftijd = 19;
            Mens.Woonplaats = "Ouderkerk a/d Amstel";
            Mens.Geslacht = GeslachtType.m;

            // PrintPersoon(Mens);
            // PrintPersoon(LeesPersoon());

            // PrintGeslacht(Mens.Geslacht);

            for (int i = 0; i < Personen.Length; i++)
            {
                Personen[i] = LeesPersoon();
                Console.WriteLine();
            }
            foreach (Persoon p in Personen)
            {
                PrintPersoon(p);
                Console.WriteLine();
            }
            

            VierVerjaardag(ref Personen[0]);
            // Na de verjaardag komt er nog steeds geen jaar bij. 
            // Hij pakt nu de method variabel "iemand" en edit die kopie daarvan
            // dus als je in de verjaardag methode de persoon aanduid als een ref, dan zal het wel de juiste geven
           
            PrintPersoon(Personen[0]);

            Console.ReadKey();

        }

        void VierVerjaardag(ref Persoon iemand)
        {
            
            
            int startLeeftijd = iemand.Leeftijd;
            int eindLeeftijd = startLeeftijd + 1;

            iemand.Leeftijd = eindLeeftijd;

            Console.WriteLine("Verjaardag vieren van {0} {1}", iemand.Voornaam, iemand.Achternaam);
            
        }


        Persoon LeesPersoon()
        {

            Persoon t = new Persoon();
            t.Voornaam = LeesString("Geef Voornaam: ");
            t.Achternaam = LeesString("Geef Achternaam: ");
            t.Leeftijd = LeesInt("Geef leeftijd: ");
            t.Woonplaats = LeesString("Geef woonplaats: ");
            t.Geslacht = LeesGeslacht("Geef Geslacht (m/v): ");
            return t;
        }

        void PrintPersoon(Persoon p)
        {
            

            Console.WriteLine("{0} {1} ({2}) ", p.Voornaam, p.Achternaam, p.Geslacht);
            Console.WriteLine("{0} jaar, {1}", p.Leeftijd, p.Woonplaats);

            // ik kan een void methode niet formatten toch?
            // vraag aan leraar, volgens mij begrijp je iets niet..
            // PrintGeslacht(p.Geslacht);
        }

        GeslachtType LeesGeslacht(string vraag)
        {
            GeslachtType gt = GeslachtType.m;
            char g;
            Console.Write(vraag);
            g = Char.Parse(Console.ReadLine());

            switch (g)
            {
                case  'm':
                    gt = (GeslachtType)1;
                    break;
                case 'v':
                    gt = (GeslachtType)2;
                    break;
                }
           

            return gt;
        }

        // PrintGeslacht geeft een geslacht, omdat dit een algemene methode zou moeten zijn,
        // lijkt het belangrijk om geen formatting erin te zetten, hoewel er wel formatting gevraagd wordt in de output. 
        void PrintGeslacht(GeslachtType geslacht)
        {
            Console.WriteLine(geslacht);
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
        // Deze methode geeft leest een string in van de gebruiker.
        string LeesString(string vraag)
        {
            string invoer;
            Console.Write(vraag);
            invoer = Console.ReadLine();
            return invoer;
        }
    }
}
