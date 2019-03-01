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
            Klant klant1 = new Klant();
            klant1.Naam = "Tim";
            klant1.GeboorteDatum = new DateTime(1999, 08, 01);

            Console.WriteLine(klant1.InschrijfDatum);
            
        }
    }
}
