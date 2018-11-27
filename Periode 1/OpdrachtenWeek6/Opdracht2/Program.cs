using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int getal;
            //invoer
            Console.Write("Enter Number (0 is stop value): ");
            getal = int.Parse(Console.ReadLine());
            //Loop
            while (getal != 0)
            {
                //input validatie
                while (getal < 0)
                {
                    Console.WriteLine("Negative number entered...");
                    Console.Write("Enter Number (0 is stop value): ");
                    getal = int.Parse(Console.ReadLine());
                }


                // Conditions maken met het resultaat (return) van de methode
                if (IsPriemGetal(getal))
                {
                    Console.WriteLine("{0} is a prime number.", getal);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number.", getal);
                }

                Console.Write("Enter Number (0 is stop value): ");
                getal = int.Parse(Console.ReadLine());
            }

            

            Console.WriteLine("End of program");
            Console.ReadKey();
        }




        // methode voor het checken van een priemgetal
        static Boolean IsPriemGetal(int getal)
        {
            // loop begint bij 2 want 0 kan niet door worden gedeeld en 1 is deelbaar door alles dus niet nodig om te checken
            for (int i = 2; i < getal; i++)
            {
                // als het getal deelbaar is door iets tussen de 1 en zichzelf, is het geen priemgetal.
                if (getal % i == 0)
                {
                    return false;
                }
            }
            // standaard return waarde
            return true;
        }
    }
}
