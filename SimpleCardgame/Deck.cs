using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCardgame
{
    class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int NumberOfCards = 52;
        private Random ranNum;

        public Deck()
        {

            string[] values =
            {
                "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack",
                "Queen", "King"
            };

            string[] suits =
            {
                "Hearts", "Clubs", "Diamonds", "Spades"
            };

            deck = new Card[NumberOfCards];
            currentCard = 0;
            ranNum = new Random();
            // Skapa och sortera kortlek med 13 kort per beklädnad (suits)
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(values[count % 13], suits[ count / 13]);
            }
        }

       public void ShuffleCards()
        {
            currentCard = 0;
            Random rand = new Random();
            Card temp;

            // blanda kortleken 1000ggr
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < NumberOfCards; i++)
                {
                    // byt ut första kortet mot det andra
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }

        public Card DealCard()
        {
            // Så länge vi är i kortleken så ska nästa kort visas
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
            {
                return null;
            }
        }
    }
}
