using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int number;
            // invoer
            Console.Write("Enter a number (1..4): ");
            number = Convert.ToInt32(Console.ReadLine());

            // switch cases met default voor out of range input.
            switch (number)
            {
                case 1:
                    Console.WriteLine("klaveren");
                    break;
                case 2:
                    Console.WriteLine("ruiten");
                    break;
                case 3:
                    Console.WriteLine("harten");
                    break;
                case 4:
                    Console.WriteLine("schoppen");
                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;

            }





            Console.ReadLine();

        }
    }
}
