using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Klant
    {
        private DateTime MINIMAAL_TIJD = new DateTime(1910);
        private string Naam;
        private DateTime Geboortejaar, InschrijfDatum;
        public string naam { get { return naam; } private set
            {
                if (value != "")
                {
                    Naam = value;
                }
            }
        }
        private DateTime geboortejaar
        {
            get { return Geboortejaar; }
            set { if (Geboortejaar.Year < DateTime.Today.Year && Geboortejaar.Year > MINIMAAL_TIJD.Year)  Geboortejaar = value;  }
        }
        public DateTime inschrijfDatum
        {   get { return InschrijfDatum; }
            private set
            {

            }
        }

        public Klant(string naam, DateTime geboortejaar)
        {
            this.naam = naam;
            this.geboortejaar = geboortejaar;
            this.inschrijfDatum = DateTime.Today;
        }

        public void printinschrijfdatum()
        {
            Console.WriteLine(InschrijfDatum.ToString("dd/MM/yyyy"));
            Console.WriteLine(Geboortejaar.ToString("dd/MM/yyyy"));
            Console.WriteLine($"deze naam ---> {Naam} <----");
        }
    }
}
