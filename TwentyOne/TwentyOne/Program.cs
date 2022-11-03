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
            int timesShuffled = 0;
            deck = Shuffle(deck,out timesShuffled, 3);// after the shuffle method runs and adds all the cards randomly to the TempList, it will return the value of that list back to deck. the deck holds all the values of the cards and 3=times which means it will run the shuffle program 3 times. 
            //the out paramater method will run the shuffle metod but instead of returning the values to deck it sends it it the timesShuffled variable for varification. 
            //deck = Shuffle(deck, 3);//this will loop the shuffle method as many times as we state times

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times Shuffled: {0}", timesShuffled); // this will alow you to see how many times the shuffled method was run. 
            Console.ReadLine();
        }

        //This method will randomly select cards and put the into a new "temperary" list that will be returned to the deck after its been "shuffled". 
        public static Deck Shuffle(Deck deck,out int timesShuffled, int times = 1)//this makes an out paramater before an optional paramater  
        {
            timesShuffled = 0;//this sets the timesShuffled variable to 0
            for(int i =0; i<times; i++)//this creates times as a paramater so that  a method can be run multiple times
            {
                timesShuffled++; //this will increase the timesShuffled paramater by one on each loop. 
                List<Card> TempList = new List<Card>();//creats a empty list where all of the cards will eventually be randomly inserted into as if shuffling the deck
            Random random = new Random();//built in random method 

            while (deck.Cards.Count > 0)//this grabs a random index and adds it to a new list. This loop will run until all cards in list have been removed.
            {
                int randomIndex = random.Next(0, deck.Cards.Count);// this create a random intager between the lowest index in the deck list which is 0 and the highst which is the "deck.Cards.Count" 
                TempList.Add(deck.Cards[randomIndex]);//this adds the card at the randomly chosen index to be placed in the "TempList" list.
                deck.Cards.RemoveAt(randomIndex); //this is a built in function of lists where it will remove the card at the randome index from the Deck list. this will contunue to remove on each loop until no cards are left
            }
            deck.Cards = TempList;// this is stating that the value of deck is now tempList.

            }
           
            return deck;//this returns the Values of the shuffled list back to deck.
        }
        ////method overload to do multiple methods
        //public static Deck Shuffle(Deck deck, int times) //this will allow the deck to be shuffled as many times as we want using times as its paramater 
        //{ for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);// this reuses the same randomIndex method from above for shuffling cards several times
        //    }
        //    return deck;//returns the Values of the shuffled list from this method back to the deck
            

        }
    }
