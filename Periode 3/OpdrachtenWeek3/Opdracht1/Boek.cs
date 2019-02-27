using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Boek : BoekHandelItem
    {
        private string auteur;
        public string Auteur
        {
            get { return auteur; }
        }
        public Boek(string titel, string auteur, double prijs, int count)
        {
            this.Titel = titel;
            this.auteur = auteur;
            this.Prijs = prijs;
            this.Count = count;
        }
        public override void PrintItemInfo()
        {
            Console.WriteLine($"[Book] '{Titel}', by {auteur}, {Prijs:0.00} ({Count}x)");
        }
    }
}
