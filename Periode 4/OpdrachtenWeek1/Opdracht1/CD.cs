using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class CD : BookStoreItem
    {
        public string Artist { get; set; }
        public CD(string titel, float prijs, int aantalItems, string artiest) : base(titel, prijs, aantalItems)
        {
            Artist = artiest;
        }
        public override string ToString()
        {
            return $"[CD] {Title} - {Artist}, {Price:0.00} ({NumberOfItems}x)";
        }
    }
}
