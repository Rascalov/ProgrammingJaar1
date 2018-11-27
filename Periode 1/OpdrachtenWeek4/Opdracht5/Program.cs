using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int jaartal;

            // invoer
            Console.Write("Voer een jaartal in: ");
            jaartal = Convert.ToInt32(Console.ReadLine());

            //iteratie, misschien is een do-while beter, hoef je maar 1 keer jaartal = invoer waarde te typen
            while (jaartal != 0)
            {
                // invoer validatie
                while (jaartal < 0)
                {
                    Console.Write("Voer een jaartal in BOVEN de nul aub: ");
                    jaartal = Convert.ToInt32(Console.ReadLine());
                }
                
                // schrikkeljaar bepalen
                if (jaartal % 400 == 0  || jaartal % 4 == 0 && jaartal % 100 != 0)
                {
                    Console.WriteLine("{0} is een schrikkeljaar.", jaartal);
                }
                else
                {
                    Console.WriteLine("{0} is geen schrikkeljaar.", jaartal);
                }
                Console.Write("Voer een jaartal in: ");
                jaartal = Convert.ToInt32(Console.ReadLine());
            }
            //loop
            Console.ReadKey();
        }
    }
}
