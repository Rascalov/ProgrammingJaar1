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


            Boek boek1 = new Boek("Galg", "Jan Terlouw", 29.50);
            Boek boek2 = new Boek("Bouw de steen", "Jan Terlouw", 33.53);
            TijdSchrift blad = new TijdSchrift("Vogue", 90.00, DayOfWeek.Monday);
            BoekHandel handel = new BoekHandel();
            
            handel.VoegToe(boek1);
            handel.VoegToe(boek2);
            
            handel.VoegToe(blad);
            handel.PrintVoorraad();
        }
    }
}
