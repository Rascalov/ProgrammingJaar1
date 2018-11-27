using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int getal1, getal2, getal3;


            // invoer
            Console.Write("Enter first number: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            getal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            getal3 = Convert.ToInt32(Console.ReadLine());


            // output per condition
            if (getal3 < getal2 && getal3 < getal1)
            {

                Console.WriteLine("The third number is the smallest of the three.");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three.");
            }


            Console.ReadKey();
        }
    }
}
