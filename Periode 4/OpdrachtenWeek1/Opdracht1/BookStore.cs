using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class BookStore
    {
        private List<BookStoreItem> Items = new List<BookStoreItem>();

        public void Add(BookStoreItem item)
        {
            Items.Add(item);
        }
        public void PrintAllItems()
        {
            foreach (BookStoreItem item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
