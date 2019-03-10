using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        private int id;
        public int Id { get { return id; }set { id = value; } }

        public string Author { get; set; }
        public string Title { get; set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
