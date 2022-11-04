using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello strange traveler! Please give me a number from 1 to 100.");
            int UserNumber = Convert.ToInt32(Console.ReadLine());//converts user string to an int and creates a variable to use in math operations

            IntOne Obj1 = new IntOne(); //creates an object from the class IntOne so that you can call the method from the objects and not the class. 
            Console.WriteLine("Let me add 15 to your number. Your number is now  " + Obj1.ChoiceOne(UserNumber));//Obj1 accesses the object and the method in that object "ChoiceOne"

            Console.WriteLine(" Great now give me a number with a decimal. I will multiply it by 15.5 and give you a whole number back.");
            decimal UserNumber2 = Convert.ToDecimal(Console.ReadLine());
            //We will now make a method overload that if a decimal is passed in it will be able to convert it to an int. 
            Console.WriteLine("Great your result is  " + Obj1.ChoiceOne(UserNumber2));//this calls the method in the Obj1 that can take in a decimal. 

            Console.WriteLine("Wonderful! Now can you once again give me a number?.. no decimal this time.");
            string UserString = Console.ReadLine();
            //this will call the method overlad that can take in a string and convert to int. 
            Console.WriteLine("Great! Now let me just add 10 to your number. " + Obj1.ChoiceOne(UserString));

            
            Console.ReadLine();
        }
    }
}
