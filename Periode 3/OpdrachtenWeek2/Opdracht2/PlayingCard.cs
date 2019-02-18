using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opdracht2
{
    public class PlayingCard
    {
        public int rank;
        public CardSuit suit;

        public PlayingCard(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            return null;
        }
    }
}