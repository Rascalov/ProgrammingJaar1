using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class WarCardGame : CardGame
    {
        public Player player1, player2;
        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }
        public void StartNewGame()
        {
            deck.Shuffle();
            while (deck.allPlayingCards.Count != 0)
            {
                PlayingCard card1 = deck.allPlayingCards[0];
                deck.allPlayingCards.Remove(deck.allPlayingCards[0]);
                PlayingCard card2 = deck.allPlayingCards[0];
                deck.allPlayingCards.Remove(deck.allPlayingCards[0]);
                player1.AddCard(card1);
                player2.AddCard(card2);
            }
        }
        public bool EndOfGame()
        {
            return player1.cards.Count == 0 || player2.cards.Count == 0 ;   
        }
        public void NextCard()
        {
            PlayingCard KaartPlayer1 = player1.GetNextCard();
            PlayingCard KaartPlayer2 = player2.GetNextCard();
            Console.WriteLine($"[{player1.name}] {KaartPlayer1.ToString()} - [{player2.name}] {KaartPlayer2.ToString()}");

            if (KaartPlayer1.rank > KaartPlayer2.rank)
            {
                player1.AddCard(KaartPlayer1);
                player1.AddCard(KaartPlayer2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[{player1.name}] got the cards");
            }
            else if(KaartPlayer1.rank < KaartPlayer2.rank)
            {
                player2.AddCard(KaartPlayer2);
                player2.AddCard(KaartPlayer1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[{player2.name}] got the cards");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards lost...");
                Console.WriteLine($"Cards left: [{player1.name}] {player1.cards.Count}x [{player2.name}] {player2.cards.Count}x");
            }
            Console.ResetColor();
        }
    }
}
