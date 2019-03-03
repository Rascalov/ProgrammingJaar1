using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Reservering : Klant
    {
        private Klant Klant { get; set; }
        public List<Kaartje> Kaartjes { get; } = new List<Kaartje>();
         
    }
}
