using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie 
            int[] getallen = new int[20];
            int invoer, zoekwaarde, teller;

            // standaard waardes
            teller = 0;




            // loop vult de array tot er 0 wordt ingevoerd
            for (int i = 0; i < getallen.Length; i++)
            {

                Console.Write("Geef een getal (0=stoppen): ");
                invoer = int.Parse(Console.ReadLine());

                if (invoer == 0)
                {
                    break;
                }


                getallen[i] = invoer;
            }



            // zoekwaarde invoer
            Console.Write("Geef de zoekwaarde: ");
            zoekwaarde = int.Parse(Console.ReadLine());

            // check of er getallen in de array zijn die overeenkomen met de zoekwaarde.
            foreach (int getal in getallen)
            {
                if (getal == zoekwaarde)
                {
                    teller++;
                }
            }

            //output
            Console.WriteLine("De zoekwaarde is : {0}", zoekwaarde);
            Console.WriteLine("De zoekwaarde komt {0} keer voor", teller);
            Console.Write("Press any key to continue");
            //loop
            Console.ReadKey();
        }
    }
}
