using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            Console.Write("Enter a text> ");
            tekst = Console.ReadLine();
            OnderzoekTekst(tekst);

            Console.ReadKey();
        }


        static void OnderzoekTekst(string tekst)
        {
            // char array 
            char[] tekstKarakters;

            // convert naar array om per char te vergelijken
            tekstKarakters = tekst.ToCharArray();
            // declaratie tellers
            int aantalPunten, aantalKommas, aantalPuntKommas;
            // standaard waardes
            aantalPunten = 0;
            aantalKommas = 0;
            aantalPuntKommas = 0;

            // loop tot het einde van de array
            for (int i = 0; i < tekstKarakters.Length; i++)
            {
                // switch statements per condition
                switch (tekstKarakters[i])
                {
                    case '.':
                        {
                            aantalPunten++;
                            break;
                        }
                    case ',':
                        {
                            aantalKommas++;
                            break;
                        }
                    case ';':
                        {
                            aantalPuntKommas++;
                            break;
                        }
                }
            }
            // output
            Console.WriteLine("Result: {0} full stops, {1} commas, {2} semicolons", aantalPunten, aantalKommas, aantalPuntKommas);
            
        }
    }


}
