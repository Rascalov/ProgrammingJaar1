using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4_LingoForm
{
    class LingoGame
    {
        public string lingoWoord;
        public string playerWoord;

        public bool IsGuessed()
        {
            return ((playerWoord.ToLower()).Equals((lingoWoord.ToLower())));
        }
        
        public States[] EvaluateWord(string playerWord, string lingoWord)
        {
            States[] results = new States[lingoWord.Length];

            List<char> refLetters = new List<char>();

            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (char.ToLower(playerWord[i]) != char.ToLower(lingoWord[i]))
                {
                    refLetters.Add(lingoWord[i]);
                }
            }

            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (char.ToLower(playerWord[i]) == char.ToLower(lingoWord[i]))
                {
                    results[i] = States.Correct;
                }
                else
                {
                    if (refLetters.Contains(playerWord[i]))
                    {
                        results[i] = States.WrongPosition;
                        refLetters.Remove(playerWord[i]);
                    }
                    else
                    {
                        results[i] = States.Incorrect;
                    }
                }
            }

            return results;
        }

    }
}
