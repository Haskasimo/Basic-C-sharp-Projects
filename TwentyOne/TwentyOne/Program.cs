using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {


            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Ben", "Mara", "Alex", "Ida" };
            game.ListPlayers();
            Console.ReadLine();
            Deck deck = new Deck();//instantiates an empty object deck baised on the Deck class.
            deck.Shuffle(3);//calls the Shuffle using the deck object

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }


    }
        ////method overload to do multiple methods
        //public static Deck Shuffle(Deck deck, int times) //this will allow the deck to be shuffled as many times as we want using times as its paramater 
        //{ for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);// this reuses the same randomIndex method from above for shuffling cards several times
        //    }
        //    return deck;//returns the Values of the shuffled list from this method back to the deck
            

  }
    
