using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //this is an abstract class or base class other classes can inherit from
    //the more genaric you can make your code, the more fetures you can add later
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();//to make sure the list is never null we instatiate a new list so that players will always equat an emptylist and not null. 
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();//this is also instantiating an empty list so that it will never appear as null. if it is null then things cant be added to it. 
        public List<Player> Players { get { return _players; } set { _players = value; } }//becuase we have a player class, we can use data type Players instead of string. {get; set;} is shorthand. this form is the full version
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }//becuse you need the public list and private list to work together, you need to change the get set to the full version.  

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
