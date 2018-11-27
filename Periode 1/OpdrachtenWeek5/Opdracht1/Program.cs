using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            // random aanmaken
            Random rnd = new Random();
            
            // array 
            int[] getallen = new int[20];
            
            // declaratie
            int totaal, teller;
            double gemiddelde, aantalGetallen, verschil;

            // start waardes
            aantalGetallen = 0;
            totaal = 0;
            teller = 0;
            

            // for loop om alle waardes in de array te krijgen
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = rnd.Next(0, 200);
                Console.WriteLine("Element {0} is {1}", i, getallen[i]);
                totaal = totaal + getallen[i];
                aantalGetallen++;
                    
               

                    
            }

            // gemiddelde berekenen
            gemiddelde = totaal / (double)aantalGetallen;

            // output tussendoor
            Console.WriteLine();
            Console.WriteLine("Het gemiddelde is {0:0.00}", gemiddelde);
            Console.WriteLine();


            // voor iedere getal opgeslagen in de array Getallen wordt er vergeleken met het gemiddelde
            foreach (int getal in getallen)
            {
                // Verschil bereken met gegarandeerd positieve getallen
                verschil = Math.Abs(getal - gemiddelde);

                //output
                Console.WriteLine("Verschil tussen gemiddelde en element {0} is {1:0.00}", teller, verschil);
                
                //teller omhoog
                teller++;
                
            }
            //loop
            Console.WriteLine("Press any key to continue "); 
            Console.ReadKey();

        }
    }
}
