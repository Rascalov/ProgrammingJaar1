using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Opdracht4_Lingo
{
    
    class Program
    {

        int pogingNummer = 1;
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            LingoGame lingo = new LingoGame();

            string path = "../../woorden.txt";
            lingo.lingoWoord = (ChooseWord(ReadWords(path)));

            if (PlayLingo(lingo))
            {
                Console.WriteLine("U heeft gewonnen!");
            }
            else
            {
                Console.WriteLine($"Jammer... Het woord was {lingo.lingoWoord}");
            }
            Console.ReadKey();
        }


        bool PlayLingo(LingoGame lingo)
        {
            bool guessed = false;

            while (!guessed && !(pogingNummer > 5) )
            {
                lingo.playerWoord = ReadPlayerWord(LingoGame.LETTER_AANTAL);
                DisplayResults(lingo.playerWoord, lingo.EvaluateWord());
                guessed = lingo.IsGuessed();
                pogingNummer++;
            }

            return guessed;
        }


        List<string> ReadWords(string file)
        {
            List<string> woordenlijst = new List<string>();
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
            {
                string woord = reader.ReadLine();
                if (woord.Length == LingoGame.LETTER_AANTAL)
                {
                    woordenlijst.Add(woord);
                }
            }
            return woordenlijst;
        }

        string ChooseWord(List<string> woordenlijst)
        {
            return (woordenlijst[rnd.Next(0, woordenlijst.Count)]);
        }

        string ReadPlayerWord(int lengte)
        {
            string woord;
            do
            {
                woord = LeesTools.LeesString($"Enter a ({LingoGame.LETTER_AANTAL}-letter) lingo word (Attempt {pogingNummer}): ");
            }
            while (woord.Length != lengte);
            return woord;
        }

        
        void DisplayResults(string playerword, States[] results)
        {
            for (int i = 0; i < playerword.Length; i++)
            {
                if (results[i] == States.Correct)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (results[i] == States.WrongPosition)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                Console.Write(Char.ToUpper(playerword[i]));
                Console.ResetColor();
            }
            Console.WriteLine();
        }

    }
}
