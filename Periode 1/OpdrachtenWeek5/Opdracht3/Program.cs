using System;
using System.Linq;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie 
            string[] namenStudenten;
            double[] cijfers;
            int aantalStudenten, aantalCijfers;
            string vak;
            double gemiddelde, hoogste, totaal;

            // standaard waardes
            aantalCijfers = 0;
            totaal = 0;

            // invoer
            Console.Write("Geef het vaknaam: ");
            vak = Console.ReadLine();

            Console.Write("Geef het aantal studenten: ");
            aantalStudenten = Convert.ToInt32(Console.ReadLine());

            //witregel
            Console.WriteLine();

            // Grootte toekennen aan de arrays
            namenStudenten = new string[aantalStudenten];
            cijfers = new double[aantalStudenten];

            // Waardes toekennen aan de variabele in namenStudenten 
            for (int i = 0; i < aantalStudenten; i++)
            {
                Console.Write("Geef de naam van de {0}e student: ", i + 1);
                namenStudenten[i] = Console.ReadLine();
            }

            //witregel
            Console.WriteLine();

            // Waardes toekennen aan de variabele in cijfers 
            for (int j = 0; j < namenStudenten.Length; j++)
            {
                Console.Write("Geef het cijfer van {0}: ", namenStudenten[j]);
                cijfers[j] = Convert.ToDouble(Console.ReadLine());

                aantalCijfers++;
                totaal = totaal + cijfers[j];

            }

            //witregel
            Console.WriteLine();

            // hoogste cijfer bepalen met een for loop, kan ook met array.Max()
            hoogste = cijfers[0];
            for (int k = 0; k < cijfers.Length; k++)
            {
                if (cijfers[k] > hoogste)
                {
                    hoogste = cijfers[k];
                }
            }



            // gemiddelde berekenen, kan ook met array.Average()
            gemiddelde = totaal / aantalCijfers;



            // output hoogste en gemiddelde
            Console.WriteLine("Het gemiddelde cijfer is: {0}", gemiddelde);
            Console.WriteLine("Het hoogste cijfer is: {0} ", hoogste);

            //witregel
            Console.WriteLine();

            // output studenten en de cijfers
            for (int l = 0; l < aantalStudenten; l++)
            {
                Console.WriteLine("Student {0} heeft voor {1} het cijfer {2}", namenStudenten[l], vak, cijfers[l]);
            }

            //loop
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }
}
