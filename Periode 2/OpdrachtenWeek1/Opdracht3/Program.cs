using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            // Eerste deel
            /*   Dobbelsteen d1, d2;
               d1 = new Dobbelsteen(); // dobbelsteen 1
               d2 = new Dobbelsteen(); // dobbelsteen 2

               d1.Gooi();
               d2.Gooi();

               d1.ToonWaarde();
               d2.ToonWaarde();
               */

            // Tweede doel 
            /* YahtzeeGame yahtzeeGame = new YahtzeeGame();
             yahtzeeGame.Init();

             yahtzeeGame.Gooi();             // gooi
             yahtzeeGame.ToonWorp();         // toon

             yahtzeeGame.Gooi();
             yahtzeeGame.ToonWorp();
             */

            // echte doel
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            yahtzeeGame.Init();
            SpeelYahtzee(yahtzeeGame);  // speel het gemaakte spel


            Console.ReadKey();
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
