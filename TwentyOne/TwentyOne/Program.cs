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


           
            //Card card = new Card();//this is an Enum 
            //card.Suit = Suit.Clubs;//this will only assign a value from the listed choices of the enum which protects agains errors 
            //int underlyingValue = (int)Suit.Diamonds;//this is casting Suit.Diamonds to an int. But instead of an error you would get with trying to convert a string to an int, it would return the underlying int value of the list starting at 0 for the fist listed choice. You can also assign special values in the list.  
            //Console.WriteLine(underlyingValue);
            

            Deck deck = new Deck();//instantiates an empty object deck baised on the Deck class.
            deck.Shuffle(3);//calls the Shuffle using the deck object

            foreach (Card card in deck.Cards)// this foreach loop will loop the through all objecs in the Cards list in the Deck class. 
            {
                Console.WriteLine(card.Face + " of " + card.Suit);//this will combine and print the values of each object in the Cards list. 
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
    
