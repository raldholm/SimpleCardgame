using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
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
            Console.WriteLine(" | Before you begin,                   |");
            Console.WriteLine(" | Enter a digit of how many decks you |");
            Console.WriteLine(" | want to use in your game, and then  |");
            Console.WriteLine(" | press 'Enter' key:                  |");
            Console.WriteLine(" |_____________________________________|");
            Console.WriteLine();
            int numberOfDecks = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Menu(numberOfDecks);
        }

        public static void Menu(int numberOfDecks)
        {
            Deck deck = new Deck();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("      S I M P L E  C A R D G A M E      ");
            Console.WriteLine("  _____________________________________ ");
            Console.WriteLine(" | MENU:                               |");
            Console.WriteLine(" | 1) SORT CARDS                       |");
            Console.WriteLine(" | 2) SHUFFLE CARDS                    |");
            Console.WriteLine(" | 3) DRAW CARD                        |");
            Console.WriteLine(" | 4) QUIT                             |");
            Console.WriteLine(" |_____________________________________|");
            Console.WriteLine();
            Console.Write("Enter digit (1-4) for menuoption: ");

            int menuValue = Convert.ToInt32(Console.ReadLine());
            if (menuValue == 1)
            {
                /* SKAPA OCH SORTERA KORTLEK METOD:
                 * Sortering skall sortera korten i kortspelet enligt färg och valör: 
                 * Hjärter(Ess,2,3 ... Kung), ruter, klöver och spader.
                 * Alla kortlekar som ingår i spelet skall sorteras.
                 * 
                 */
                SortCards(numberOfDecks,deck);
                Menu(numberOfDecks);
                
            }
            if (menuValue == 2)
            {
                 /* BLANDA KORTLEK METOD:
                  * Blandning av korten skall lägga korten i kortspelet i slumpvis ordning.
                  */
                ShuffleCards(numberOfDecks, deck);
                Menu(numberOfDecks);
            }
            if (menuValue == 3)
            {
                /*TAKE CARD METOD:
                 *Dra kort skall visa det översta kortet i kortspelet tills dess att alla kort är dragna.
                 * Alla kort ska kunna visas.
                 */
                ShowTopCardOfGame(numberOfDecks, deck);
                Menu(numberOfDecks);
            }
            if (menuValue == 4)
            {
                Environment.Exit(0);
            }
            else
            {
                Menu(numberOfDecks);

            }

        }

        public static void ShowTopCardOfGame(int numberOfDecks, Deck deck)
        {
            Console.Clear();
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("All cards drawn, press any key to return..");
            Console.ReadKey();

        }

        public static void SortCards(int numberOfDecks, Deck deck)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("      S I M P L E  C A R D G A M E      ");
            Console.WriteLine("  _____________________________________ ");
            Console.WriteLine(" |                                     |");
            Console.WriteLine(" |               SORT                  |");
            Console.WriteLine(" |               DECKS                 |");
            Console.WriteLine(" |                                     |");
            Console.WriteLine(" |_____________________________________|");
            Console.WriteLine();
            Console.WriteLine("Press any key to sort [" + numberOfDecks + "] decks of cards: --->");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            for (int value = 0; value < numberOfDecks; value++)
            {

                for (int i = 0; i < 52; i++)
                {
                    Console.Write("{0,-19}", deck.DealCard());
                    if ((i + 1) % 4 == 0)
                    { Console.WriteLine(); }

                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue..");
                Console.WriteLine();
                Console.ReadKey();

            }

        }

        public static Deck ShuffleCards(int numberOfDecks, Deck deck)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("      S I M P L E  C A R D G A M E      ");
            Console.WriteLine("  _____________________________________ ");
            Console.WriteLine(" |                                     |");
            Console.WriteLine(" |              SHUFFLE                |");
            Console.WriteLine(" |               DECKS                 |");
            Console.WriteLine(" |                                     |");
            Console.WriteLine(" |_____________________________________|");
            Console.WriteLine();
            Console.WriteLine("Press any key to shuffle [" + numberOfDecks + "] decks of cards: --->");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            for (int value = 0; value < numberOfDecks; value++)
            {
                deck.ShuffleCards();
                for (int i = 0; i < 52; i++)
                {
                    Console.Write("{0,-19}", deck.DealCard());
                    if ((i + 1) % 4 == 0)
                    { Console.WriteLine(); }

                }
                Console.WriteLine();
                Console.WriteLine("Press any key to continue..");
                Console.WriteLine();
                Console.ReadKey();

            }
            return deck;
        }
    }
}
