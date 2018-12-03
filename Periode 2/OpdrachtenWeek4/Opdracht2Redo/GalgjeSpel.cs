using System;
using System.Collections.Generic;
using System.Text;


namespace Opdracht2Redo
{
    class GalgjeSpel
    {
        public string geheimWoord, geradenWoord;

        public void Init(string geheimwoord)
        {
            geheimWoord = geheimwoord;
            geradenWoord = "";
            for (int i = 0; i < geheimwoord.Length; i++)
            {
                geradenWoord = geradenWoord + ".";
            }
        }
        public bool RaadLetter(char letter)
        {
            if (geheimWoord.Contains(letter))
            {
                // pleur geradenwoord value naar een char array
                char[] deLetters = geradenWoord.ToCharArray();
                for (int i = 0; i < geheimWoord.Length; i++)
                {
                    if(letter == geheimWoord[i])
                    {
                       // verander de char array 
                       deLetters[i] = letter;
                    }
                }
                // zet char array weer om naar een string
                String letters = new string(deLetters);
                // en zet het woord weer gelijk aan die string
                geradenWoord = letters;

                return true;
            }

            return false;
        }
        public bool IsGeraden()
        {

            if (geradenWoord == geheimWoord)
            {
                return true;
            }

            return false;
        }
    }
}
