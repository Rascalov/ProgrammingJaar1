using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Boek
    {
        private string titel, auteur;
        public double prijs;

        public Boek(string titel, string auteur, double prijs)
        {
            this.titel = titel;
            this.auteur = auteur;
            this.prijs = prijs;
        }

        public void PrintBoekInfo()
        {
            Console.WriteLine($"{titel}, by {auteur}, {prijs}");
        }
    }
}
