using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite number? \n Please enter your guess.");
            int Number = Convert.ToInt32(Console.ReadLine()); //takes input from the user and assigns it the value of "Number"
            bool Guess = Number == 8; //creating a true /fase statment that if the variable "Number's" value is equal to 8 it will be true, if not it will be false.  

            do // the do statement will run the while loop atleast once in full even if the conditions are met right away. 
            {
                switch (Number)// like branching this will create mutiple outcomes if certain conditions are met. This is assigning the switchstatement to the variable "Number"
                {
                    case 18: //this states that if the value of the variable "Number" is equal to 18 then this section of code will execute. 
                        Console.WriteLine("oh to high.... Try again!");
                        Console.WriteLine("guess a number.");//because the conditions of guess were not met, the program will not end and contunue to loop. the guess a number will print and urge for another guess
                        Number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("oh to low.... Try again!");
                        Console.WriteLine("guess a number.");
                        Number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Yay you guessed it!! My favorite number is 8! good Job!");
                        Guess = true;//this will switch the bool to true and end the loop. 
                        break;
                    default:// defult will show when anything other then the above options is typed
                        Console.WriteLine("Not quite. Try again!");
                        Console.WriteLine("guess a number.");
                        Number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!Guess);// this creates a loop stateing that if the bool guess = false then Console.WriteLine("guess a number.") will trigger and it will loop the program again untill Number == 8 or Guess == true.

            {
               
            }
            Console.ReadLine();
           
        }
    }
}
