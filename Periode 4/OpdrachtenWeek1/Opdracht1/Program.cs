using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
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
            BookStore winkeltje = new BookStore();
            winkeltje.Add(new Book("Dracula", 15.00f, 5, "Bram Stoker"));
            winkeltje.Add(new Book("Joe Speedboot", 12.50f, 5, "Tommy Wieringa"));
            winkeltje.Add(new Magazine("Time", 3.90f, 10, DayOfWeek.Friday));
            winkeltje.Add(new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday));
            winkeltje.Add(new CD("The Cure", 3.90f, 5, "Seventeen Seconds"));
            winkeltje.PrintAllItems();
        }
    }
}
