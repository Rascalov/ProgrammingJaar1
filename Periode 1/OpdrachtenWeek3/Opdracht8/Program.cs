using System;

namespace Opdracht8
{
    class Program
    {
        static void Main(string[] args)
        {
            int werkuren, leeftijd, storingen;

            Console.Write("Enter number of working hours: ");
            werkuren = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of years: ");
            leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of failures: ");
            storingen = Convert.ToInt32(Console.ReadLine());


            if (werkuren > 10000 || leeftijd >= 7 || storingen > 25)
            {
                Console.WriteLine("\n Machine needs to be replaced.");
            }
            else
            {
                Console.Write("\n Machone does not need to be replaced.");
            }
            Console.ReadLine();
        }
    }
}
