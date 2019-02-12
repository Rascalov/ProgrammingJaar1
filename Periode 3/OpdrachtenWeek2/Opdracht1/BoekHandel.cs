using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class BoekHandel : Boek
    {
        private List<Boek> boekenLijst = new List<Boek>();
        
        public void VoegToe(Boek boek)
        {
            boekenLijst.Add(boek);
        }
        public void PrintVoorraad()
        {
            double totaal = 0;
            foreach (Boek boek in boekenLijst)
            {
                boek.PrintBoekInfo();
                totaal += boek.prijs;
            }
            Console.WriteLine($"\nTotal Price: {totaal}");
        }

    }
}
