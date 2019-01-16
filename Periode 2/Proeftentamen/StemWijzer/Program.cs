using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StemWijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadKey();
        }

        void Start()
        {
            string bestandStellingen = "../../../stellingen.txt";
            string bestandPartijen = "../../../partijen.txt";

            List<Stelling> stellingen = LeesStellingen(bestandStellingen);
            List<Partij> partijen = LeesPartijen(bestandPartijen);

            if (partijen.Count == 0 || stellingen.Count == 0)
            {
                Console.WriteLine("Geen Stellingen en/of Partijen in bestand(en)");
                return;
            }
            
            VergelijkPartijen(DoorloopStellingen(stellingen), partijen);
            


        }
        void VergelijkPartijen(string gebruiker, List<Partij> partijen)
        {
            foreach(Partij partij in partijen)
            {
                Console.WriteLine($"{partij.naam,-5}: {BepaalMatchPercentage(gebruiker, partij):0.00} %");
            }
        }

        string DoorloopStellingen(List<Stelling> stellingen)
        {
            int count = 1;
            string input = "";
            foreach (Stelling stelling in stellingen)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} {1}", count, stelling.titel);
                Console.ResetColor();
                Console.WriteLine("{0}" , stelling.tekst);
                Console.WriteLine();
                Console.Write("Geef uw mening (1=eens / 2=oneens / 3=geen: ");
                input = input + Console.ReadLine();
                Console.WriteLine();
                count++;
            }
            return input;
        }

        double BepaalMatchPercentage(string gebruiker, Partij partij)
        {
            int aantalOvereenstemmende = 0;
            for (int i = 0; i < partij.antwoorden.Length; i++)
            {
                if (gebruiker[i].Equals(partij.antwoorden[i]))
                {
                    aantalOvereenstemmende++;
                }
            }
            return (double)aantalOvereenstemmende / gebruiker.Length * 100;
        }

        List<Stelling> LeesStellingen(string bestand)
        {
            List<Stelling> stellingen = new List<Stelling>();
            StreamReader reader = new StreamReader(bestand);

            while (!reader.EndOfStream)
            {
                Stelling stelling = new Stelling();
                stelling.titel = reader.ReadLine();
                stelling.tekst = reader.ReadLine();
                stellingen.Add(stelling);
            }
            return stellingen;
        }

        List<Partij> LeesPartijen(string bestand)
        {
            List<Partij> partijen = new List<Partij>();
            StreamReader reader = new StreamReader(bestand);

            while (!reader.EndOfStream)
            {
                Partij partij = new Partij();
                partij.naam = reader.ReadLine();
                partij.antwoorden = reader.ReadLine();
                partijen.Add(partij);
            }
            return partijen;
        }

    }
}
