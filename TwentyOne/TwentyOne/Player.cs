using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActiveltPlaying { get; set; }

        public static Game operator+ (Game game, Player player)//overloaded operator to add a player to the game list and returning the game. This allows you to add different game objects
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)//overloaded operator to subtract a player from the game list and returning the game.
        {
        game.Players.Remove(player);
            return game;
        }

    }
}
 