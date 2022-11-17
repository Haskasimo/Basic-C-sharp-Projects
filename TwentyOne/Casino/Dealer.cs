using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());//takes the first item from the list Deck.Cards and adds it to the Hand list.
           // string card = string.Format(Deck.Cards.First().ToString() + "\n");//this will take the first card the dealer deals and store it in the string value card. 
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");//writes the chosen card to the console
           //this is how you append text to a file outside the program. This will log every single card delt to a file. 
            //using (StreamWriter file = new StreamWriter(@"C:\Users\Mara\Documents\Logs\log.txt", true)) //streams are unmanaged code that will get disposed after use. to do this you type "using" streamwriter will take the path of where the log is. and "true" means to append to the log.
            //{
               // file.WriteLine(card);//this tells what we want to appended to the file. we want to append the string stored in "card" which would be each card delt.  
           // }
                Deck.Cards.RemoveAt(0);//removes the item in the Deck.Cards List at position 0 or the first card in the list. 
        }
    }
}
