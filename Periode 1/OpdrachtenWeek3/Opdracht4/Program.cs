using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            // dit programma gaat ervan uit dat er geen duplicate getallen gebruikt worden bij 
            // invoer


            // declaratie
            int getal1, getal2, getal3, product, hoogste, laagste;
            double gemiddelde, som;

            //vooraf waarde
            hoogste = 0;
            laagste = 0;

            // invoer
            Console.Write("Enter first number: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            getal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            getal3 = Convert.ToInt32(Console.ReadLine());

            // Waarde berekend aan de hand van de invoer
            som = getal1 + getal2 + getal3;
            gemiddelde = som / 3;
            product = getal1 * getal2 * getal3;

            // bepaal hoogste waarde met conditions
            if (getal1 > getal2 && getal1 > getal3)
            {
                hoogste = getal1;
            }
            else if (getal2 > getal1 && getal2 > getal3)
            {
                hoogste = getal2;
            }
            else if (getal3 > getal2 && getal3 > getal1)
            {
                hoogste = getal3;
            }

            // bepaal laagste waarde met conditions
            if (getal1 < getal2 && getal1 < getal3)
            {
                laagste = getal1;
            }
            else if (getal2 < getal1 && getal2 < getal3)
            {
                laagste = getal2;
            }
            else if (getal3 < getal2 && getal3 < getal1)
            {
                laagste = getal3;
            }

            // output


            Console.WriteLine("sum: {0} \n" +
                              "average: {1:0.00} \n" +
                              "product: {2} \n" +
                              "highest: {3} \n" +
                              "lowest:  {4}", som, gemiddelde, product, hoogste, laagste);

            Console.WriteLine("что это дерьмо??");

            Console.ReadLine();
                    
        }
    }
}
