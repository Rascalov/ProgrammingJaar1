using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class TijdSchrift : BoekHandelItem
    {
        private DayOfWeek dagVanUitgave;
        public DayOfWeek DagVanUitgave
        {
            get { return dagVanUitgave; }
            set { dagVanUitgave = value; }
        }
        public TijdSchrift(string titel, double prijs, DayOfWeek dagVanUitgave, int count)
        {
            this.Titel = titel;
            this.Prijs = prijs;
            this.dagVanUitgave = dagVanUitgave;
            this.Count = count;
        }
        public override void PrintItemInfo()
        {
            Console.WriteLine($"[Magazine] {Titel} - release day: {dagVanUitgave}, {Prijs:0.00} ({Count}x)");
        }
    }
}
