using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int getal1, getal2, uitkomst, teller;

            // begin waardes
            getal1 = 1;
            getal2 = 1;
            teller = 1;
            uitkomst = getal1 + getal2;

            //output 1
            Console.Write("{0}, {1},  ", getal1, getal2);
            // iteratie
            do
            {
                // output 2 en verder
                Console.Write("{0},  ", uitkomst);
                getal1 = getal2;
                getal2 = uitkomst;
                uitkomst = getal1 + getal2;
                teller++;

            }
            // tot de teller op 19 staat.
            while (teller != 19);




            // 2de poging, gaat veel makkelijker met for loop.
            Console.WriteLine();

            int g1, g2, uit;
            g1 = 1;
            g2 = 0;
            uit = g1 + g2;
            for (int i = 0; i < 20; i++)
            {
                
                Console.Write("{0}, ", uit);
                g1 = g2;
                g2 = uit;
                uit = g1 + g2;
                
            }

            Console.ReadKey();
        }
    }
}
