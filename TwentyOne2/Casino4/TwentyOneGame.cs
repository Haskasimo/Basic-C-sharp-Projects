using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino4.TwentyOne2
{
   public class TwentyOneGame : Game //By adding a colen it states that trhis class is going to inherit from the game class 
    {
        public TwenteyOneDealer Dealer { get; set; }

        public override void Play()//this is inheritng the abstract play method from Game class, but the override allows you to change the method. 
        {
            Dealer = new TwenteyOneDealer();
            foreach(Player player in Players)//this will reset the players hand for every loop in the game while loop
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();


            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if (bet < 0)
                {
                    throw new FraudException("You try'n to be a wise guy?... SECURITY!! KICK THIS CHEATER OUT!");


                }

                
                bool successfullyBet = player.Bet(bet);
                if(!successfullyBet)
                {
                    return;//this is a void method so this wont return anything, but it will end this method and go back to the while loop.  
                }
                //if the bet is succsessful then this creates a dictionary object for bet so its easy to look up the values of betsd for players.
                Bets[player] = bet;//this creates a dictionary inherited from the Game class. If the Bet was successful it will make a dictionary entry where "player" is the Key and "bet" is the value.  
            }

            //This will loop and give everyone a card.
            for (int i = 0; i < 2; i++)// i <2 is because we want it to only loop twice and gice 2 cards. 
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("[0]: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        //Method that checks for Black Jack.
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if(blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Bets.Remove(player);
                            return;
                             
                        }
                    }
                }Console.WriteLine("Dealer; ");
                Dealer.Deal(Dealer.Hand);
                if (i==1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while(!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\n Hit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer =="stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}. ", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again? Yes or No");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes"|| answer == "yeah")
                        {
                            player.isActiveltPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActiveltPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is busted!");
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //bu adding the questionmark it makes it possible to ass null to the value. 
                if(playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer Wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes"|| answer == "yeah")
                {
                    player.isActiveltPlaying = true;
                }
                else
                {
                    player.isActiveltPlaying = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 players:  ");
            base.ListPlayers();//this is the ovverride method ListPlayers from the Game class
        }
    }
}
