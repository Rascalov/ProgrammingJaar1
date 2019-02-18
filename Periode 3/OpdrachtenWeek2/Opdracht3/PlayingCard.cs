using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opdracht3
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
            string name;
            switch (rank)
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
                    name = rank.ToString();
                    break;
            }
            return $"{name} of {suit}";
        }
    }
}