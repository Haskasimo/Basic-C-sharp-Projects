using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the Glacier Peaks Casino. Let's start by telling me your name.");
            string PlayerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today? ");
            int Bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", PlayerName); //because PlayerName will be added to the Players class, this will take the name enter at index 0. {0} 
            string Answer = Console.ReadLine().ToLower();
            
            if (Answer == "yes" || Answer =="yeah" || Answer == "y" ||Answer == "ya")
            {
                //if user answers in any of the above way, this block of code will trigger. 
                Player player = new Player(PlayerName, Bank); //this is an object created from the constructor for the player class. This initializes it with the begining values of name and beggining money bank.  
                Game game = new TwentyOneGame();//polymorphisim is to expose the overloaded operators. 
                game += player;//this adds player to Game class
                player.isActiveltPlaying = true; //property of the player class which means while the player is playing, continue as well
               
                //using a while loop it can keep the loop running while certain conditions are happening. but while loops can be problematic. 
                while (player.isActiveltPlaying && player.Balance >0)//if these two conditions are met (is the player still activly play, and does the player still have money in the bank) theloop will keep going.  
                {
                    game.Play();
                }
                game -= player;//if the while conditions are no longer mwt, it will take the player out of the game class, and play this message. 
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");//If the User answers No instead of Yes when asked to play, it will not load the player into the game and not start the game while loop. This mesage will trigger instead.  
            Console.ReadLine();




        }
    }

  }
    
