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
            Book b1 = new Book("Dracula", 15.00f, 5, "Bram Stoker");
            Book b2 = new Book("Joe Speedboot", 12.50f, 5, "Tommy Wieringa");
            Magazine m1 = new Magazine("Time", 3.90f, 10, DayOfWeek.Friday);
            Magazine m2 = new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday);
            CD cd1 = new CD("The Cure", 3.90f, 5, "Seventeen Seconds"); 
            winkeltje.Add(b1);
            winkeltje.Add(b2);
            winkeltje.Add(m1);
            winkeltje.Add(m2);
            winkeltje.Add(cd1);

            winkeltje.PrintAllItems();


        }
    }
}
