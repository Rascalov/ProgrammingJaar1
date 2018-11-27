using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2;


            Console.Write("Enter first number: ");
            getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            getal2 = Convert.ToInt32(Console.ReadLine());

            if (getal1 % getal2 == 0)
            {
                Console.Write("Number 1 is multiple of number 2");
            }
            else if (getal2 % getal1 == 0)
            {
                Console.Write("Number 2 is multiple of number 1");
            }
            else
            {
                Console.Write("Numbers are no multiples");
            }
            Console.ReadKey();
        }
    }
}
