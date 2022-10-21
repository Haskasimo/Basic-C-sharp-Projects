using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //This is creating a class for cards. This will set the general properties for all objects that fit in this class.
   public class Card
    {
        public Card()//another way to make properties for objects is create a constructor. This will give the object defult properties automaticaly upon creation.
        {
            Suit = "Spades";
            Face = "two";

        }
        //this is a way you can create porperties that you can change the values of later on. 
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
