using System;
using System.IO;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Console.Write("Zoek woord: ");
            string woord = Console.ReadLine();

            Console.WriteLine(ZoekWoordInBestand("Tweets.txt", woord));
            Console.ReadKey();
        }

        bool ZitWoordInRegel(string regel, string woord)
        {
            if (regel.ToLower().Contains(woord.ToLower())){
                return true;
            }

            return false;
        }
        int ZoekWoordInBestand(string bestandsnaam, string woord)
        {
            int teller = 0;
            StreamReader reader = new StreamReader(bestandsnaam);
            while (!reader.EndOfStream)
            {
                if (ZitWoordInRegel(reader.ReadLine(), woord))
                {
                    teller++;
                }
            }
            return teller;
        }

        void ToonWoordInRegel(string regel, string woord)
        {
            
            Console.WriteLine(regel);
        }
    }
}
