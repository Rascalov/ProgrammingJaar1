using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            String escape = "end";
            String invoerEind;
            Random rnd = new Random();
            int getal1, getal2, getal3, getal4;

            Console.Write("Typ end om te stoppen of klik enter om door te gaan. ");
            invoerEind = Console.ReadLine();

            while (invoerEind != escape)
            {

                getal1 = rnd.Next(101, 1000);
                getal2 = rnd.Next(101, 1000);
                getal3 = rnd.Next(101, 1000);
                getal4 = rnd.Next(101, 1000);
                int getalUitkomst = getal1 + getal2 + getal3 + getal4;

                Console.WriteLine("Wat is {0} + {1} + {2} + {3}?", getal1, getal2, getal3, getal4);
                int invoerUitkomst;


                invoerUitkomst = Convert.ToInt32(Console.ReadLine());

                bool isGoed;
                isGoed = (invoerUitkomst == getalUitkomst);

                Console.WriteLine("Uw antwoord is: {0}. Het antwoord is {1}", isGoed, getalUitkomst);

                Console.Write("Typ end om te stoppen of klik enter om door te gaan. ");
                invoerEind = Console.ReadLine();
                // Console.ReadLine();
            }
        }
    }
}
