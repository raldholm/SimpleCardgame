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
    
    }
    

}
