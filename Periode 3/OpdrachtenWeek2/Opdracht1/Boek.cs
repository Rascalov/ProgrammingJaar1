using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Boek
    {
        public string titel, auteur;
        public double prijs;
        public virtual void PrintBoekInfo()
        {
            Console.WriteLine($"[Book] '{titel}', by {auteur}, {prijs:0.00}");
        }
    }
}
