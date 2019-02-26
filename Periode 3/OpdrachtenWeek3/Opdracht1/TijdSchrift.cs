using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class TijdSchrift : BoekHandelItem
    {
        public DayOfWeek dagVanUitgave;
        public TijdSchrift(string titel, double prijs, DayOfWeek dagVanUitgave)
        {
            this.titel = titel;
            this.prijs = prijs;
            this.dagVanUitgave = dagVanUitgave;
        }
        public override void PrintItemInfo()
        {
            Console.WriteLine($"[Magazine] {titel} - release day: {dagVanUitgave}, {prijs:0.00}");
        }
    }
}
