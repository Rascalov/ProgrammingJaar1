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
            DeckOfCards deck = new DeckOfCards();
            deck.Print();
            Console.WriteLine(deck.allPlayingCards.Count);
            deck.Shuffle();

            Console.WriteLine();
            deck.Print();

            Console.WriteLine(deck.allPlayingCards.Count);
            
        }
    }
}
