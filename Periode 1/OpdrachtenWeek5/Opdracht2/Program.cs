using System;
using System.Linq;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //random
            Random rnd = new Random();
            //array
            int[] getallen = new int[20];
            // declaratie
            int laagste;

            // standaard waardes
            teller = 0;
            laagste = 0;
            // loop om waardes van de array te bepalen en te printen
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = rnd.Next(0, 150);
                Console.WriteLine("Element {0}: {1}", i, getallen[i]);


            }
            // loop voor check laagste getal voor laagste getal
            // kan ook .Min gebruiken met Linq extension
            laagste = getallen[0];
            int teller = 1;
            for (int j = 1; j < getallen.Length; j++)
            {

                if (getallen[j] < laagste)
                {
                    laagste = getallen[j];
                    teller = 1;
                }
                else if (getallen[j] == laagste)
                {
                    teller++;
                }
            }
            
            
            
            /*

            // check hoe vaak het laatste getal voorkomt.
            foreach (int getal in getallen)
            {
                if (getal == laagste)
                {
                    teller++;
                }
            }*/

            //output
            Console.WriteLine("Het laagste getal is {0}. Het kwam {1} keer voor.", laagste, teller);
            //loop
            Console.ReadKey();
        }
    }
}
