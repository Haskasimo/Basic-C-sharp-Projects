using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class Program

    {
        //This program is using a void Method where the method does not return any values but can display information to the console. 
        static void Main(string[] args)
        {
            Math Numbers = new Math();//First we instantiate an object Numbers from the Math Class.  
            

            Console.WriteLine("Hello, Welcome to my program. Please give me a number.");
            int Number1 = Convert.ToInt32(Console.ReadLine()); //Getting first number from user

            Console.WriteLine("Great. Now please give me your second number.");
            int Number2 = Convert.ToInt32(Console.ReadLine());//Getting second nunber from the user. 

            Numbers.Multiply(Number1, Number2);//because the method is a void method it cant return any values so we just need to call the methos to have it disply whatever was writen in the Console.WritreLine in the method. 
            Numbers.Multiply(Choice1: 4, Choice2: 5);// We can also call the method and passing in our own paramaters using "named paramaters" by naming a paramater name from the class method, we can assign a value to a specific paramater.  

            Console.ReadLine();

        }
    }
}
