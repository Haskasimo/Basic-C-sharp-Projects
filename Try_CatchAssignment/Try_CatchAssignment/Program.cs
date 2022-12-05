using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_CatchAssignment
{

    //This program is practicing what would happen if you run into user input errors and how to handel them in different ways. 
    class Program
    {
        static void Main(string[] args)
        {
            bool validAge = false;//first we astablish a true false statement that if our method succeeds then it will be true and it will move on but to start we assign Validage the value of false so that it will br able to loop. 
            int age = 0;//our starting value of age if user does not answer. 
            while (!validAge)//the is saying that while validAge = false continue to loop the following code.  
            {
                try//this is a try catch block. This states that the program will try to execute all the code in the try, and if there are any errors then it will pass it to the catch block.  
                {
                    Console.WriteLine("Well hello there. How old are you??");//asking for user input.
                    age = Convert.ToInt32(Console.ReadLine());//converting input from string to intager
                    if(age < 1) { throw new AgeException(); }//if the user enters a 0 or a negative number, then this would throw an exception and trigger the catch block handeling the AgeException (a special exception written by the developer)

                    validAge = true;//if all code is seccesful and age has been converted properly this would change validAge to true and exit the while loop, as the loop will only continue to run as long as validAge = false. 
                    
                    DateTime Today = DateTime.Now;// gets the current date and time
                    DateTime Birthday = Today.AddYears(-age);// buy using .addYears we are only targeting the years in DateTime Today. We then subtract the age of the user to get their Birthday.
                    Console.WriteLine("You were born in the year " + Birthday.Year);//displaying only the birth year to the console.
                    Console.ReadLine();
                }

                catch (AgeException)//this is a special exception that is thrown if the user enters a 0 or negative numbers. 
                {
                    Console.WriteLine("Your age must be at least 1 and not be negative");
                    Console.ReadLine();
                }
                catch (Exception) //this is a defult exception that will trigger if anything goes wrong in the try block, unless another catch is specified. 
                {
                    Console.WriteLine("Please enter digits only");
                    Console.ReadLine();
                    
                }

                
                
           
            }
            
        }
    }
}
