using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
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
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");
            // create game and play it
            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
        }
        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame())
            {
                war.NextCard();
            }
            Console.WriteLine();
            if (war.player2.cards.Count == 0 && war.player1.cards.Count != 0)
            {
                Console.WriteLine($"{war.player1.name} has won");
            }
            else if(war.player1.cards.Count == 0 && war.player2.cards.Count != 0)
            {
                Console.WriteLine($"{war.player2.name} has won");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
