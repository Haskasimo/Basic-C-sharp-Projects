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
            Deck deck = new Deck();//instantiates an empty object deck baised on the Deck class.
            deck = Shuffle(deck);// after the shuffle method runs and adds all the cards randomly to the TempList, it will return the value of that list back to deck.

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //This method will randomly select cards and put the into a new "temperary" list that will be returned to the deck after its been "shuffled". 
        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();//creats a empty list where all of the cards will eventually be randomly inserted into as if shuffling the deck
            Random random = new Random();//built in random method 

            while (deck.Cards.Count > 0)//this grabs a random index and adds it to a new list. This loop will run until all cards in list have been removed.
            {
            int randomIndex = random.Next(0, deck.Cards.Count);// this create a random intager between the lowest index in the deck list which is 0 and the highst which is the "deck.Cards.Count" 
                TempList.Add(deck.Cards[randomIndex]);//this adds the card at the randomly chosen index to be placed in the "TempList" list.
                deck.Cards.RemoveAt(randomIndex); //this is a built in function of lists where it will remove the card at the randome index from the Deck list. this will contunue to remove on each loop until no cards are left
            }
            deck.Cards = TempList;// this is stating that the value of deck is now tempList.
            return deck;//this returns the Values of the shuffled list back to deck.



        }
    }
}
