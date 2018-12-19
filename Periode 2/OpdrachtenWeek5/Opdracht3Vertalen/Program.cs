using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Opdracht3Vertalen
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
            Dictionary<string, string> woordenlijst = new Dictionary<string, string>();
            TranslateWords(ReadWords("../../dictionary.csv"));
            
        }


        Dictionary<string, string> ReadWords(string filename)
        {
            Dictionary<string, string> woordenlijst = new Dictionary<string, string>();
            string[] woorden = new string[2];
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string regel = reader.ReadLine();
                woorden = regel.Split(';');
                woordenlijst.Add(woorden[0], woorden[1]);
            }
            return woordenlijst;
        }

        void TranslateWords(Dictionary<string, string> words)
        {
            string invoer = LeesTools.LeesString("Enter a word: ");
            while (invoer != "stop")
            {
                if (invoer.Equals("listall"))
                {
                    ListAllWords(words);
                }
                else
                {
                    while (!words.ContainsKey(invoer))
                    {
                        Console.WriteLine($"word '{invoer}' not found ");
                        invoer = LeesTools.LeesString("Enter a word: ");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{invoer} => {words[invoer]}");
                    Console.ResetColor();
                    
                }
                invoer = LeesTools.LeesString("Enter a word: ");
            }
        }
        void ListAllWords(Dictionary<string, string> words)
        {
            foreach (KeyValuePair<string, string> word in words)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{word.Key} => {word.Value}");
            }
            Console.ResetColor();
        }
    }
}
