using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    class HangmanGame
    {
        public string secretWord, guessedWord;

        public void Init(string secretword)
        {
            secretWord = secretword;
            guessedWord = "";
            for (int i = 0; i < secretword.Length; i++)
            {
                guessedWord = guessedWord + ".";
            }
        }
    }
}
