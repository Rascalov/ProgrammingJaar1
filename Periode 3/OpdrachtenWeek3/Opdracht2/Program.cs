using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            // Kaartjes
            Kaartje c1 = new Kaartje("Bohemian Rhapsody", 1, 10.50m, 6, new DateTime(2019, 02, 23, 21, 30, 00));
            Kaartje c2 = new Kaartje("The Progidy", 4, 10.50m, 16, new DateTime(2019, 02, 23, 22, 00, 00));
            Kaartje c3 = new Kaartje("Green Book", 5, 10.50m, 12, new DateTime(2019, 02, 25, 19, 00, 00));
            // Klantjes
            Klant k1 = new Klant("Lionel Messi", new DateTime(1987, 06, 24), new DateTime(2019, 02, 20));
            Klant k2 = new Klant("Piet Paulusma", new DateTime(1956, 12, 15), new DateTime(2017, 02, 20));
            // Reserveringtjes
            Reservering r1 = new Reservering(k1);
            r1.Kaartjes.Add(c1);
            r1.Kaartjes.Add(c2);
            r1.Kaartjes.Add(c3);
            Reservering r2 = new Reservering(k2);
            r2.Kaartjes.Add(c1);
            r2.Kaartjes.Add(c2);
            r2.Kaartjes.Add(c3);
            // Printjes
            k1.Print();
            k2.Print();
            r1.Print();
            r2.Print();
        }
    }
}
