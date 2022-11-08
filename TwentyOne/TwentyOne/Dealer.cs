using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());//takes the first item from the list Deck.Cards and adds it to the Hand list. 
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");//writes the chosen card to the console
            Deck.Cards.RemoveAt(0);//removes the item in the Deck.Cards List at position 0 or the first card in the list. 
        }
    }
}
