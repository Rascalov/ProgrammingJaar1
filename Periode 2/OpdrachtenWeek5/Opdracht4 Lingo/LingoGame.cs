using MyTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4_Lingo
{
    class LingoGame
    {
        public const int LETTER_AANTAL = 5;
        public string lingoWoord;
        public string playerWoord;

        public bool IsGuessed()
        {
            return (playerWoord.Equals(lingoWoord));
        }
        
        public States[] EvaluateWord()
        {
            States[] results = new States[lingoWoord.Length];

            List<char> refLetters = new List<char>();

            for (int i = 0; i < lingoWoord.Length; i++)
            {
                if (char.ToLower(playerWoord[i]) != char.ToLower(lingoWoord[i]))
                {
                    refLetters.Add(lingoWoord[i]);
                }
            }

            for (int i = 0; i < lingoWoord.Length; i++)
            {
                if (char.ToLower(playerWoord[i]) == char.ToLower(lingoWoord[i]))
                {
                    results[i] = States.Correct;
                }
                else
                {
                    if (refLetters.Contains(playerWoord[i]))
                    {
                        results[i] = States.WrongPosition;
                        refLetters.Remove(playerWoord[i]);
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
