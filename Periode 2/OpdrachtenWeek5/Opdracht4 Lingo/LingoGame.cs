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
        public int pogingen;
        public string lingoWoord;
        public string playerWoord;

        public string ReadPlayerWord()
        {
            string woord;
            do
            {
                woord = LeesTools.LeesString("Enter a (5-letter) lingo word");
            } while (woord.Length != Constanten.LINGO_LETTERS);
            return woord;
        }
        public bool IsGuessed(string lingoword, string playerword)
        {
            return (playerWoord.Equals(lingoword));
        }
    }

}
