using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opdracht2
{
    public class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards;
        public DeckOfCards()
        {
            allPlayingCards = new List<PlayingCard>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    PlayingCard card = new PlayingCard(j, (CardSuit)i);
                    allPlayingCards.Add(card);
                }
            }
        }

        private void InitCards()
        {
            
        }

        public void Print()
        {
            foreach (PlayingCard card in allPlayingCards)
            {
                string name;
                switch (card.rank)
                {
                    case 11:
                        name = "Jack";
                        break;
                    case 12:
                        name = "Queen";
                        break;
                    case 13:
                        name = "King";
                        break;
                    case 14:
                        name = "Ace";
                        break;
                    default:
                        name = card.rank.ToString();
                        break;
                }
                Console.WriteLine($"{name} of {card.suit}");
            }
        }
        public void Shuffle()
        {
            allPlayingCards = allPlayingCards.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }
}