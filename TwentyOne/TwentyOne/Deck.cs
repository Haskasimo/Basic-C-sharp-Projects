using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //This creates the object deck 
    public class Deck
    {
        public Deck()//to make an entire deck of 52 cards it easier to make a nested foreach loop
        {
            Cards = new List<Card>();//refers to the property of the class so it does not need a data type. This makes an empty list of cards
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };//creats two lists of values
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            //starts a nested for each loop to create a list of card objects. 
            foreach (string face in Faces)//there are 13 properties in the faces
            {
                foreach(string suit in Suits)//there are 4 properties in this list so it will loop the 13 items in Faces List 4 times. 
                {
                    Card card = new Card();//this will create a new card object  
                    card.Suit = suit;// this will assign the value from the Suits list: Example "Clubs"
                    card.Face = face;//This will assign the value from the face list: Example "Five" 
                    Cards.Add(card);//This adds it into the Cards list. This only exsits inside the loop so it can create an item over and over agin with the same name. 
                }
            }
        }
        public List<Card> Cards { get; set; } //make sure all classes are set to public

        //This method will randomly select cards and put the into a new "temperary" list that will be returned to the deck after its been "shuffled". 
        public void Shuffle(int times = 1)//void states that it will handles values intrnaly but will not return value. 
        {
           
            for (int i = 0; i < times; i++)//this creates times as a paramater so that  a method can be run multiple times
            {
                
                List<Card> TempList = new List<Card>();//creats a empty list where all of the cards will eventually be randomly inserted into as if shuffling the deck
                Random random = new Random();//built in random method 

                while (Cards.Count > 0)//this grabs a random index and adds it to a new list. This loop will run until all cards in list have been removed.
                {
                    int randomIndex = random.Next(0, Cards.Count);// this create a random intager between the lowest index in the deck list which is 0 and the highst which is the "deck.Cards.Count" 
                    TempList.Add(Cards[randomIndex]);//this adds the card at the randomly chosen index to be placed in the "TempList" list.
                    Cards.RemoveAt(randomIndex); //this is a built in function of lists where it will remove the card at the randome index from the Deck list. this will contunue to remove on each loop until no cards are left
                }
                Cards = TempList;// this is stating that the value of deck is now tempList.

            }

        }
        }
}
