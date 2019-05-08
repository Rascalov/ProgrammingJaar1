using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    public class Song
    {
        public string Titel { get; set; }
        public string Bandnaam { get; set; }
        public DateTime Duur { get; set; }
        public Song(string titel, string bandnaam, DateTime duur)
        {
            Titel = titel;
            Bandnaam = bandnaam;
            Duur = duur;
        }
    }
}
