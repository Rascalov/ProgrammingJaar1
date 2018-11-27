using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int getal1, getal2;

            // invoer
            Console.Write("Enter first number: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            getal2 = Convert.ToInt32(Console.ReadLine());

            // conditions en uitvoer per condition
            if (getal1 > getal2)
            {
                Console.WriteLine("Highest value is: {0}", getal1);
                Console.WriteLine("Lowest value is: {0}", getal2);

            }
            else if (getal2 > getal1)
            {
                Console.WriteLine("Highest value is: {0}", getal2);
                Console.WriteLine("Lowest value is: {0}", getal1);

            }
            else
            {
               Console.WriteLine("Both values: {0} and {1} are equal.", getal1, getal2);
            }

            Console.ReadLine();
        }
    }
}
