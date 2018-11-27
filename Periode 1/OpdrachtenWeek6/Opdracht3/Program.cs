using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int jaartal;
            //invoer
            Console.Write("Enter year (0 is stop value): ");
            jaartal = int.Parse(Console.ReadLine());

            //loop tot input 0
            while (jaartal != 0)
            {

                // Conditions maken met het resultaat (return) van de methode
                if (IsSchrikkelJaar(jaartal))
                {
                    Console.WriteLine("{0} is a leap year", jaartal);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", jaartal);
                }

                Console.Write("Enter year (0 is stop value): ");
                jaartal = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("end of program");
            Console.ReadKey();

        }

        static Boolean IsSchrikkelJaar(int jaartal)
        {
            // conditions voor een schrikkeljaar
            if (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0)
            {
                return true;
            }

            //default return waarde
            return false;
        }
    }
}
