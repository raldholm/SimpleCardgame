using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCardgame
{
    class Card
    {
        private string _value;
        private string _suit;
      

        // Konstruktor
        public Card(string cardValue, string cardSuit)
        {
            _value = cardValue;
            _suit = cardSuit;
        }

        // ToString Override
        public override string ToString() { return _value + " of " + _suit; }

        public enum Suit
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades
        }

        public enum Value
        {
            Ace = 1,
            Deuce = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

    }
    

}
