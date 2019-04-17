using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Book : BookStoreItem
    {
        public string Author { get; set; }
        public Book(string titel, float prijs, int itemAantal, string author) : base(titel, prijs, itemAantal)
        {
            Author = author;
        }
        public override string ToString()
        {
            return $"[Book] {Author} - {Title}, {Price} ({NumberOfItems}x)";
        }
    }
}
