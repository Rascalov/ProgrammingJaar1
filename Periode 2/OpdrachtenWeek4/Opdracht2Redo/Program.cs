using System;
using System.Collections.Generic;
using System.IO;

namespace Opdracht2Redo
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
            List<string> woordenLijst = new List<string>();
            WoordenLijst(woordenLijst);

            GalgjeSpel galgje = new GalgjeSpel();

            string sekretwoord = SelecteerWoord(woordenLijst);
            galgje.Init(sekretwoord);

            if (SpeelGalgje(galgje))
            {
                Console.WriteLine("Je hebt gewonnen!");
            }
            else
            {
                Console.WriteLine("Jammer, het woord was '{0}' ", galgje.geheimWoord);       
            }

           
            Console.ReadKey();
        }

        char LeesLetter(List<char> verbodenLetter)
        {
            char letter;
            Console.Write("Geef een letter ");
            letter = char.Parse(Console.ReadLine());
            while (verbodenLetter.Contains(letter))
            {
                Console.WriteLine("Deze letter heb je al gebruikt!");
                Console.Write("Geef een letter ");
                letter = char.Parse(Console.ReadLine());
            }
            
            return letter;
        }


        void ToonLetters(List<char> letters)
        {
            Console.Write("Ingevoerde letters: ");
            foreach (char letter in letters)
            {
                Console.Write("{0} ", letter);
            }
        }

        void ToonWoord(string woord)
        {
            for (int i = 0; i < woord.Length; i++)
            {
                Console.Write("{0} ", woord[i]);
            }
        }

        bool SpeelGalgje(GalgjeSpel galgje)
        {
            int levens = 8;
            List<char> ingevoerdeLetters = new List<char>();
            while (levens > 0)
            {
                ToonWoord(galgje.geradenWoord);
                Console.WriteLine();
                if (galgje.IsGeraden())
                {
                    Console.WriteLine();
                    return true;
                }
               
                Console.WriteLine();


                char letter = LeesLetter(ingevoerdeLetters);

                if (!galgje.RaadLetter(letter))
                {
                    levens--;
                }

                Console.Write("Aantal pogingen over: {0}", levens);
                Console.WriteLine();
                ingevoerdeLetters.Add(letter);
                ToonLetters(ingevoerdeLetters);
                Console.WriteLine();
                Console.WriteLine();
            }

           
            return false;
        }



        List<string> WoordenLijst(List<string> lijst)
        {
            // het idee: zorg ervoor dat woorden met minder dan drie letters niet in de lijst komen.
            const int MINIMUM_LETTERS = 2;
            StreamReader reader = new StreamReader("words.txt");

            while (!reader.EndOfStream)
            {
                // store de readline in een string, als je de readline gaat vergelijken en dan de readline in de lijst zet
                // dan pakt hij de de volgende (en dus verkeerde) readline.
                string woord = reader.ReadLine();
                if (woord.Length > MINIMUM_LETTERS)
                {
                    lijst.Add(woord);
                }
            }
            reader.Close();
            // oude lijst
            /*
            lijst.Add("boek");
            lijst.Add("koek");
            lijst.Add("zoek");
            lijst.Add("vloek");
            lijst.Add("roek");
            lijst.Add("poek");
            lijst.Add("koeoek");
            lijst.Add("oek");
            lijst.Add("snoek");
            lijst.Add("kerstkoek");
            lijst.Add("kroepoek");
            lijst.Add("pannenkoek");
            lijst.Add("leerboek");
            lijst.Add("appoek");
            lijst.Add("woord");
            lijst.Add("ik");
            lijst.Add("heb");
            lijst.Add("geen");
            lijst.Add("leven");
            */

            return lijst;
        }


        string SelecteerWoord(List<string> woorden)
        {
            // omdat ik bij de lijst al de woorden filter, is het hier niet nodig.
            // maar om volgens de opdracht te werken:

            /*
            Random rnd = new Random();
            string woord = "";
            do
            {
               woord = woorden[rnd.Next(0, woorden.Count)]
            } while (woord.Length < 3);
            return woord;
            */
            Random rnd = new Random();
            return woorden[rnd.Next(0, woorden.Count)];
        }
    }
}
