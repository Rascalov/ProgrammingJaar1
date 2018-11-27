using System;

namespace Opdracht1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            
            PrintMaanden();
            Console.WriteLine();

            int nummer;
            
            nummer = (int)VraagMaand("Voer een maandnummer in: ");
            Console.Write("{0} => ", nummer);
            PrintMaand((Maand) nummer);
            
            Console.ReadKey();
            
        }


        // Deze methode vraagt een Maand nummer binnen de defined range en returned hem
        Maand VraagMaand(string vraag)
        {
            int maandNummer;
            Console.Write(vraag);
            maandNummer = int.Parse(Console.ReadLine());
            while (!Enum.IsDefined(typeof(Maand), maandNummer))
            {
                Console.WriteLine("{0} is geen geldige waarde.", maandNummer);
                Console.Write(vraag);
                maandNummer = int.Parse(Console.ReadLine());
            }

            return (Maand)maandNummer;
        }

        // Deze methode print een gevraagde Maand
        void PrintMaand(Maand maand)
        {
             Console.WriteLine(maand);
        }
        // Deze methode print alle maanden in de Enum lijst.
        void PrintMaanden()
        {
            for (Maand m = Maand.Januari;  m <= Maand.December; m++)
            {
                int nummer;
                nummer = (int)m;
                Console.Write(" {0,2}. ", nummer);
                PrintMaand(m);
            }
        }
            
    }
}
