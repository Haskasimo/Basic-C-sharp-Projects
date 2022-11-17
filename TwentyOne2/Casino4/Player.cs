using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino4
{
    public class Player
    {
        public Player (string name, int beginningBalance)//This is a Constructor for the player class
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActiveltPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }//creating a guid property to you can assign a unique identifier to the player on creation. 

        public bool Bet(int amount)
        {
            if(Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator+ (Game game, Player player)//overloaded operator to add a player to the game list and returning the game. This allows you to add different game objects
        {
            game.Players.Add(player);//this is adding to a list so you have to make sure you instatiate a list so it can add the value to it. 
            return game;
        }
        public static Game operator- (Game game, Player player)//overloaded operator to subtract a player from the game list and returning the game.
        {
        game.Players.Remove(player);
            return game;
        }

    }
}
 