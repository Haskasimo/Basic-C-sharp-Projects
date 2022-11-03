using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAsign2
{

    //this program is doing 3 simple math functions on users input.
    //this program has a class called Numbers where three different math methods are stored. This program will then call each method aby name and pass the users input as a paramater for the function to use to get aq result.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int UserNumber = Convert.ToInt32(Console.ReadLine());//this is creating a variable using the users input so it can be used by varius methods to ceated differnt results. 


            Console.WriteLine("Let's add 10 to your number! Your answer would be " + Numbers.Add10(UserNumber));// accessing the class Numbers.method name Add10(user input);
            Console.WriteLine("Great now let's take 5 away from your number. Your answer would be " + Numbers.Sub5(UserNumber));// accessing the class Numbers.method name Sub5(user input);
            Console.WriteLine("Ok! Last one, what would your number be if we divided it in half?...rounded of course.  Your number would be " + Numbers.div2(UserNumber)); //accessing the class Numbers.method name div2(user input);
        Console.ReadLine();
        }
    }
}
