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
        public Deck()//to make an entire deck of 52 cards it eaier to make a nested foreach loop
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
    }
}
