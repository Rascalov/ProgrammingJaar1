using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            double getal1, getalTotaal, aantalGetallen, gemiddelde;

           
            // standaard waardes
            getalTotaal = 0;
            aantalGetallen = 0;

            // gebruik do while zodat de iteratie tenminste 1 keer wordt gedraaid.
            do
            {
                Console.Write("Voer getal in: ");
                getal1 = Convert.ToInt32(Console.ReadLine());


                // check op positief getal
                if (getal1 > 0)
                {

                    // positieve getallen worden toegevoegd aan het Totaal en het aantalGetallen
                    getalTotaal = getalTotaal + getal1;
                    aantalGetallen++;
                }

            }
            while (getal1 != 0);

            // bereken gemiddelde
            gemiddelde = getalTotaal / aantalGetallen;

            //output
            Console.WriteLine("Het gemiddelde v/d positieve getallen is: {0:0.00}", gemiddelde);

            Console.ReadKey();
        }
    }
}
