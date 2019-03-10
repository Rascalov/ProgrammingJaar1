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
        private DateTime geboorteDatum;
        public DateTime InschrijfDatum { get; private set; }
        // ctor met datum van vandaaf als inschrijfDatum
        public Klant(string naam, DateTime geboorteDatum)
        {
            InschrijfDatum = DateTime.Today.Date;
            Naam = naam;
            GeboorteDatum = geboorteDatum;
        }
        // ctor met een door de user bepaalde inschrijfDatum, voor scenario testing
        public Klant(string naam, DateTime geboorteDatum, DateTime inschrijfDatum) :
            this(naam, geboorteDatum)
        {
            InschrijfDatum = inschrijfDatum;
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
        public int Leeftijd
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - geboorteDatum.Year;
                if (geboorteDatum > today.AddYears(-age)) age--;
                return age;
            }
        }
        public bool RechtOpKorting
        {
            get
            {
                double inschrijfD = double.Parse(InschrijfDatum.ToString("yyyyMMdd"));
                double vandaag = double.Parse(DateTime.Today.ToString("yyyyMMdd"));
                return (Math.Floor((vandaag - inschrijfD) / 10000)) >= 1;
            }
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(naam);
            Console.ResetColor();
            Console.WriteLine($"date of birth: {GeboorteDatum.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"age: {Leeftijd}");
            Console.WriteLine($"date of registration: {InschrijfDatum.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"discount: {RechtOpKorting}");
            Console.WriteLine();
        }
    }
}
