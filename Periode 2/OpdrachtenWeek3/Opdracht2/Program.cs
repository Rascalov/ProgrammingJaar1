using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Opdracht2
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
            HangmanGame hangman = new HangmanGame();
            PlayHangman(hangman);
            List<string> words = new List<string>();
            
            hangman.Init(SelectWord(ListOfWords(words)));
            DisplayWord(hangman.guessedWord);
            Console.WriteLine("The secret word is: " + hangman.secretWord);
            Console.WriteLine("The guessed word is: " + hangman.guessedWord);

            Console.ReadKey();
        }

        void DisplayLetters(List<char> letter)
        {
            Console.WriteLine(letter + " ");
        }
        void DisplayWord(string word)
        {
            Console.Write("The secret word is: ");
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("{0} ", word[i]);
            }
           

        }
        char ReadLetter(List<char> blacklistletters)
        {
            char letter;

            Console.Write("Enter a letter: ");
            letter = Char.Parse(Console.ReadLine());
            while (blacklistletters.Contains(letter))
            {
                Console.WriteLine("{0} was already used", letter);
                Console.Write("Enter a letter: ");
                letter = Char.Parse(Console.ReadLine());
            }
            blacklistletters.Add(letter);


            return letter;
        }   

        bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();
            DisplayLetters(enteredLetters);
            return true;
        }

        List<string> ListOfWords(List<string> list)
        {
            list.Add("Boek");
            list.Add("Koek");
            list.Add("Zoek");
            list.Add("Vloek");
            list.Add("Roek");
            list.Add("Poek");
            list.Add("Koeoek");
            list.Add("Oek");
            list.Add("Snoek");
            list.Add("Kerstkoek");
            list.Add("Kroepoek");
            list.Add("Pannenkoek");
            list.Add("Leerboek");
            list.Add("Appoek");
            list.Add("Woord");
            list.Add("Ik");
            list.Add("Heb");
            list.Add("Geen");
            list.Add("Leven");


            return list; 
        }

        string SelectWord(List<string> words)
        {
            Random rnd = new Random();
            return words[rnd.Next(0, words.Count)];
        }
    }
}
