using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Player
    {
        public string name;
        public List<PlayingCard> cards;

        public Player(string name)
        {
            this.name = name;
            cards = new List<PlayingCard>();
        }

        public void AddCard(PlayingCard card)
        {
            cards.Add(card);
        }
        public PlayingCard GetNextCard()
        {
            PlayingCard card = cards[0];
            cards.Remove(cards[0]);
            return card;
        }
    }
}
