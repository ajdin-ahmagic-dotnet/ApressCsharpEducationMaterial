using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards_Library
{
    public class Card
    {
        // Osobine.
        public readonly Suit suit;
        public readonly Rank rank;

        // Konstruktori.
        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public Card()
        {

        }

        // Override metode.
        public override string ToString()
        {
            return String.Format("The {0} of {1}s", rank, suit);
        }
     
    }
}
