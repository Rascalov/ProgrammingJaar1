using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie en toekenning
            int invoer;
            string uitvoer = "";
            Console.Write("Geef een getal: ");
            invoer = int.Parse(Console.ReadLine());

            // loop met uitweg 0 en mingetallen
            while (invoer != 0 || invoer < 0)
            {
                // bepaal de helft van het getal
                int helft = invoer / 2;

                // loop tot de helft voor de sterretjes
                for (int i = 0; i < helft; i++)
                {
                    uitvoer = uitvoer + "*";
                }

                // bepaal het overige
                int overig = invoer - helft;
                // loop tot het overige voor de uitroeptekens
                for (int i = 0; i < overig; i++)
                {
                    uitvoer = uitvoer + "!";
                }

                // output en repeat
                Console.WriteLine(uitvoer);
                uitvoer = "";
                Console.Write("Geef een getal: ");
                invoer = int.Parse(Console.ReadLine());
            }
            // einde en loop
            Console.WriteLine();
            Console.WriteLine("einde programma");
            Console.ReadKey();
        }
    }
}
