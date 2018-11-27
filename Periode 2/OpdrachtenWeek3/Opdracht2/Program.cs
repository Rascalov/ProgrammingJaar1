using System;
using System.Collections.Generic;

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
            List<string> words = new List<string>();
            HangmanGame hangman = new HangmanGame();
            hangman.Init("backdoor");
            Console.WriteLine("The secret word is: " + hangman.secretWord);
            Console.WriteLine("The guessed word is: " + hangman.guessedWord);
            Console.ReadKey();
        }


        List<string> ListOfWords()
        {

            return 
        }

        string SelectWord(List<string> words)
        {

        }
    }
}
