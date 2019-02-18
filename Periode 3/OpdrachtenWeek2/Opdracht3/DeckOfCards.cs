using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opdracht3
{
    public class DeckOfCards
    {
        public List<PlayingCard> allPlayingCards;
        public DeckOfCards()
        {
            allPlayingCards = new List<PlayingCard>();
            InitCards();
        }

        private void InitCards()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    PlayingCard card = new PlayingCard(j, (CardSuit)i);
                    allPlayingCards.Add(card);
                }
            }
        }

        public void Print()
        {
            foreach (PlayingCard card in allPlayingCards)
            {
                Console.WriteLine(card.ToString()); 
            }
        }
        public void Shuffle()
        {
            allPlayingCards = allPlayingCards.OrderBy(a => Guid.NewGuid()).ToList(); // kan ook met een random object
        }
    }
}