using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Klant
    {
        // bij non automatic properties call bij constructor de private versie
        private DateTime MINIMAAL_TIJD = new DateTime(1910);
        private string naam;
        private DateTime geboorteDatum, inschrijfDatum;
        public Klant()
        {
            inschrijfDatum = InschrijfDatum;
        }
        public string Naam
        {
            get { return naam; }
            set
            {
                if (value != "")
                {
                    naam = value;
                }
            }
        }
        public DateTime GeboorteDatum
        {
            get { return geboorteDatum; }
            set
            {
                if (value.Year > MINIMAAL_TIJD.Year && value.Year < DateTime.Today.Year)
                {
                    geboorteDatum = value;
                }
            }
        }
        public DateTime InschrijfDatum
        {
            get { return inschrijfDatum; }
            private set { inschrijfDatum = DateTime.Today.Date; }
        }
        public int Leeftijd
        {
            get
            {
                int geboorte = int.Parse(geboorteDatum.ToString("yyyymmdd"));
                int vandaag = int.Parse(DateTime.Today.ToString("yyyymmdd"));
                return (vandaag - geboorte) / 10000;
            }
        }
        public bool RechtOpKorting
        {
            get
            {
                int geboorte = int.Parse(inschrijfDatum.ToString("yyyymmdd"));
                int vandaag = int.Parse(DateTime.Today.ToString("yyyymmdd"));
                return ((vandaag - geboorte) / 10000) >= 1;
            }
        }
        

    }
}
