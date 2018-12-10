using System;
using MyTools;

namespace MyToolsApplication
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
            int getal = LeesTools.LeesInt("tik een getal: ");
            Console.WriteLine("Je hebt {0} ingetikt", getal);

            int leeftijd = LeesTools.LeesInt("hoe oud ben je? ", 0, 120);

            string naam = LeesTools.LeesString("Hoe heet je? ");
            Console.WriteLine("Aangenaam kennis met je te maken, {0}.", naam);

            Console.ReadKey();
        }
    }
}
