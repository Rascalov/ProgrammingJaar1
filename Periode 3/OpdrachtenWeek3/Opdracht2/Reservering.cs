using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Reservering
    {
        public Klant Klant { get; set; }
        public List<Kaartje> Kaartjes { get; private set; }
       
        public Reservering(Klant klant)
        {
            Kaartjes = new List<Kaartje>();
            Klant = klant;
        }
        public decimal TotaalPrijs
        {
            get
            {
                decimal totaal = 0;
                foreach (Kaartje kaart in Kaartjes)
                {
                    decimal korting = 0;
                    if (Klant.Leeftijd < kaart.MinimumLeeftijd)
                    {
                        throw new Exception($"Error: Customur (age {Klant.Leeftijd}) is not old enough for {kaart.FilmNaam} ({kaart.MinimumLeeftijd})");
                    }
                    if (kaart.Korting)
                    {
                        korting = korting + (kaart.Prijs * 0.05m);
                    }
                    totaal = totaal + kaart.Prijs - korting;
                }
                if (Klant.RechtOpKorting)
                {
                    totaal -= (totaal * 0.10m);
                }
                return totaal;
            }
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"creating tickets for {Klant.Naam}...");
            Console.ResetColor();
            foreach (Kaartje kaart in Kaartjes)
            {
                Console.WriteLine($"created ticket '{kaart.FilmNaam}', starttime: {kaart.AanvangTijd.ToString("dd/MM/yyyy HH:mm:ss")} price: {kaart.Prijs:0.00} room: {kaart.Zaal} ({kaart.MinimumLeeftijd}+)");
            }
            Console.WriteLine($"total price of reservation: {TotaalPrijs:0.00}");
            Console.WriteLine();
        }
        
    }
}
