using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class BookStoreItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }

        public BookStoreItem(string titel, float prijs, int itemAantal)
        {
            Title = titel;
            Price = prijs;
            NumberOfItems = itemAantal; 
        }
    }
}
