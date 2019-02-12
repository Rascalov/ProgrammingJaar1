using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class TijdSchrift : Boek
    {
        public DayOfWeek dagVanUitgave;
        public override void PrintBoekInfo()
        {
            Console.WriteLine($"[Magazine] {titel} - release day: {dagVanUitgave}, {prijs:0.00}");
        }
    }
}
