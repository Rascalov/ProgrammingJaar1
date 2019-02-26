using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Boek : BoekHandelItem
    {
        public string auteur;
        public Boek(string titel, string auteur, double prijs)
        {
            this.titel = titel;
            this.auteur = auteur;
            this.prijs = prijs; 
        }
        public override void PrintItemInfo()
        {
            Console.WriteLine($"[Book] '{titel}', by {auteur}, {prijs:0.00}");
        }
    }
}
