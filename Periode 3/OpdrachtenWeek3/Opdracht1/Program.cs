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
            Console.ReadKey();
        }
        void Start()
        {


            Boek boek1 = new Boek("Dracula", "Bram Stoker", 15.00, 5);
            Boek boek2 = new Boek("Joe Speedboot", "Tommy Wieringa", 12.50, 5);
            TijdSchrift blad1 = new TijdSchrift("Time", 3.90, DayOfWeek.Monday, 10);
            TijdSchrift blad2 = new TijdSchrift("Donald Duck", 2.50, DayOfWeek.Monday, 8);
            Boek boek3 = new Boek("The hobbit", "J.R.R. Tolkien", 12.50, 4);

            BoekHandel handel = new BoekHandel();
            
            handel.VoegToe(boek1);
            handel.VoegToe(boek2);
            handel.VoegToe(blad1);
            handel.VoegToe(blad2);
            handel.VoegToe(boek3);
            
            
            handel.PrintVoorraad();
        }
    }
}
