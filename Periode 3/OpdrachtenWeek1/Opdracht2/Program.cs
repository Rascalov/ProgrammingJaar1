using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            SpeelYahtzee(yahtzeeGame);  // speel het gemaakte spel
        }


        void SpeelYahtzee(YahtzeeGame game)
        {
            int aantalpogingen = 0;
            do
            {
                game.Gooi();
                game.ToonWorp();

                aantalpogingen++;
            }
            while (!game.Yahtzee() && !game.FourOfAKind() && !game.ThreeOfAKind());

            // Ga na volgens de yahtzee hierarchie welke er is gegooid en hoe lang dat duurde
            if (game.Yahtzee())
            {
                Console.WriteLine("Aantal pogingen nodig voor Yahtzee: {0}", aantalpogingen);
            }
            else if (game.FourOfAKind())
            {
                Console.WriteLine("Aantal pogingen nodig voor Four Of A Kind: {0}", aantalpogingen);
            }
            else if (game.ThreeOfAKind())
            {
                Console.WriteLine("Aantal pogingen nodig voor Three Of A Kind: {0}", aantalpogingen);
            }

        }
    }
}
