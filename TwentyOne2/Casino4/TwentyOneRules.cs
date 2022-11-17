using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino4.TwentyOne2
{//This class is only to store methods that the program will eventually need. These will all be static because we don't want to ceate an objects in order to perform logic  
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()//A dictionary is better for all the cards and values more than an enum becuse the Ace will have multiple values. 
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1 //becuase you can't assign multiple values we will assign it the value of 1 and we can change the value with logic later
        };
        //Because the Ace can either be a value of 1 or a value of 11 we need a method that checks for all possible values, 
        public static int[] GetAllPossibleHandValues(List<Card> Hand)//first we create a method that returns an array of intagers
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);//First we find out how many Aces are in hand with a Lambda function 
            int[] result = new int[aceCount + 1];//Now we look for how many possible results there could be if you have two ace cards there will be 3 possible results so we add one to the acecount
            int value = Hand.Sum(x => _cardValues[x.Face]);//using the Lambda Sum. we can look up each cards value in the _cardValues Dictionary using Face as the Key, and then sum up the values. 
            result[0] = value;//we now take the first intager in the array result and assign value to it.
            if (result.Length == 1) return result;//if there are no aces there is only one possible answer and we can just return result. 
            
            for(int i =1; i<result.Length; i++)//since we already have the first value of Ace=1 we find the other possible values with this for loop
            {
                value += (i * 10);//If you have more then 1 have you make a seperate value and add 10 to it. so two aces would be 1 *10 and if you had 3 it would be 2 *10. 
                result[i] = value;//high
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)//This will return true or false if the hand contains an Ace and a face card. 
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();//this is a lmbda expression that check for the highest possible value of Hand
            if (value == 21) return true;//checks for blackjack
            else return false;
        }
        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }
        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach(int value in possibleHandValues)
            {
                if (value >16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }
        //This method returns a nullable boolien
        public static bool? CompareHands (List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;//if the player beates the dealer
            else if (playerScore < dealerScore) return false;//if the dealer beats the player
            else return null;//if they are equal return null
        }
    }
}
