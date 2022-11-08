using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class TwentyOneGame : Game //By adding a colen it states that trhis class is going to inherit from the game class 
    {
        public override void Play()//this is inheritng the abstract play method from Game class, but the override allows you to change the method. 
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 players:  ");
            base.ListPlayers();//this is the ovverride method ListPlayers from the Game class
        }
    }
}
