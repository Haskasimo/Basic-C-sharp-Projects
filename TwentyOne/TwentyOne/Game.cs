using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //this is an abstract class or base class other classes can inherit from
    //the more genaric you can make your code, the more fetures you can add later
    public abstract class Game
    {
        public List<Player> Players { get; set; }//becuase we have a player class, we can use data type Players instead of string. 
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //this is an abstract method that only states that anyclass inheriting this class must implement a play method.
        public virtual void ListPlayers()//the vertual method inside of an abstract class gets inherited but has the aboility to override. 
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
