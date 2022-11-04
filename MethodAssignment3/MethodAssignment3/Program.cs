using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment3
{
    class Program
    {
        static void Main(string[] args)

            //In this program we are using an optional paramater incase the user does not enter one. This will create a defult value to a paramater if the user does not specify one
        {
            Numbers Numb = new Numbers(); //first we instatiate an object of the class Numbers

            //Now we will have the user give us a number, convert it to an intager, and assign it to the variable Number1
            Console.WriteLine("Hello! Lets do some math. \n First I need a number can you give me one?");
            int Number1 = Convert.ToInt32(Console.ReadLine());

            //For the second number we will also get it from the user, but will give the user the option to leave it blank. Intagers can not have Null Null values to we need to include it as well as calling the method Adition in a Try Catch block. 
            try//This will try to assign the value to Number2. If the user does not enter a number it will throw an error and pass it to the catch.  
            {
                Console.WriteLine("Great! now we need another number! \n Don't worry, if you cant think of one I can think of one for you. ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Great! Now lets add the two numbers and 35 together! \n Our new number is   " + Numb.Addition(Number1, Number2)); // if the user enters two numbers they will be included as paramaters for the method to use.

            }
            catch
            {
                Console.WriteLine("Great! Now lets add the two numbers and 35 together! \n Our new number is   " + Numb.Addition(Number1)); // if the user skips the second number, it will use the number the user enterd and the defult value of 20 for Number2 from the class Numbers.  

            }




            Console.ReadLine();
        }
    }
}
