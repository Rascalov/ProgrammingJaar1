using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
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
            /*
            Klant klant1 = new Klant("Tim", new DateTime(1999, 08, 01));
            klant1.Naam = "Jack";
            klant1.Print();

            Klant klant2 = new Klant("Tim Sanou", new DateTime(1990, 08, 01), new DateTime(2018, 02, 03));
            klant2.Print();
            */
            Kaartje krt1 = new Kaartje();
            krt1.FilmNaam = "";
            krt1.AanvangTijd = new DateTime(2019, 02, 25, 19, 15, 00);
            krt1.Zaal = 1432;
            krt1.MinimumLeeftijd = 132123;


        }
        void PrintKlant(Klant k)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(k.Naam);
            Console.ResetColor();
            Console.WriteLine($"Date of birth: {k.GeboorteDatum.ToString("dd/MM/yyyy")}\n" +
                              $"age: {k.Leeftijd}\n" +
                              $"date of registration: {k.InschrijfDatum.ToString("dd/MM/yyyy")}\n" +
                              $"discount: {k.RechtOpKorting}\n");
        }
    }
}
