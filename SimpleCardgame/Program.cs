using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCardgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("      S I M P L E  C A R D G A M E      ");
            Console.WriteLine("  _____________________________________ ");
            Console.WriteLine(" |                                     |");
            Console.WriteLine(" | Enter a digit of how many decks you |");
            Console.WriteLine(" | want to use in your game, and then  |");
            Console.WriteLine(" | press 'Enter' key:                  |");
            Console.WriteLine(" |_____________________________________|");
            Console.WriteLine();
            int numberOfDecks = Convert.ToInt32(Console.ReadLine());
            ShuffleCards(numberOfDecks);
        }
        
        public static void ShuffleCards(int numberOfDecks)
        {
            Console.WriteLine();
            Console.WriteLine("Shuffling ["+ numberOfDecks + "] decks: ---> ");
            Console.WriteLine();
            for (int value = 0; value < numberOfDecks; value++)
            {
                Deck deck1 = new Deck();
                deck1.ShuffleCards();
                for (int i = 0; i < 52; i++)
                {
                    Console.Write("{0,-19}", deck1.DealCard());
                    if ((i + 1) % 4 == 0)
                    { Console.WriteLine(); }
                }
                Console.WriteLine(); 
                Console.WriteLine("Press any key to continue..");
                Console.WriteLine();
                Console.ReadKey();
            }
           
        }
    }
}
