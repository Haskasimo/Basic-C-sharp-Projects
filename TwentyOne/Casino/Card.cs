using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //This is creating a class for cards. This will set the general properties for all objects that fit in this class.
    public struct Card
    {
        //this is a way you can create porperties that you can change the values of later on. 
        public Suit Suit { get; set; }//because the suite objects is now and enum, the data type is no longrt string it is "Suit"
        public Face Face { get; set; }
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);//overrides the basic tostring method and makes it set up the write mformat exactirly how you want it. 
        }
    }
    public enum Suit //enum is a list of on in a set of constraints. Enums have underlying int datatype of 0 for clubs, and 3 for Spades, the underlying value can be manually set. Enums have specific constraints for the values of this class. Only the listed suits can be used as values. 
    {
        Clubs, //underlying values can be manually set for (example typing Clubs=4, would make the underling value of clubs 4.) 
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
    

