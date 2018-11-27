using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            string invoer;
            string[] woorden = new string[20];

            // invoer woorden in array dmv loop
            for (int i = 0; i < woorden.Length; i++)
            {
                Console.Write("Geef een woord:");
                invoer = Console.ReadLine();
                // geen invoer betekent break uit de loop
                if (invoer == "")
                {
                    break;
                }
                woorden[i] = invoer;
            }

            // loop per woord in woorden[]
            foreach (string woord in woorden)
            {
                // voor het geval er minder dan 20 woorden zijn wordt de eerste null encoutered beantwoord met een break
                if (woord == null)
                {
                    break;
                }

                // conditions voor de letterkleur
                if (woord.Length % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(woord);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(woord);
                }
            }
            // reset kleur, eind tekst en loop
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("einde programma");
            Console.ReadKey();



        }
    }
}
