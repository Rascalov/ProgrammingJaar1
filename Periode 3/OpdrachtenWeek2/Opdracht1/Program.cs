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
            Boek boek1 = new Boek();
            BoekHandel handel = new BoekHandel();
            boek1.titel = "Galg";
            boek1.auteur = "Jan Terlouw";
            boek1.prijs = 29.50;
            Boek boek2 = new Boek();
            boek2.titel = "Bouw de steen";
            boek2.auteur = "Jan Terlouw";
            boek2.prijs = 33.53;

            handel.VoegToe(boek1);
            handel.VoegToe(boek2);
            TijdSchrift blad = new TijdSchrift();
            blad.titel = "Vogue";
            blad.prijs = 90.00;
            blad.dagVanUitgave = DayOfWeek.Monday;
            handel.VoegToe(blad);
            handel.PrintVoorraad();
        }
    }
}
