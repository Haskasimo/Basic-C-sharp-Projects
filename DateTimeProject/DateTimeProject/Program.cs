using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Todays date and time is.. " + DateTime.Now);//using DateTime.Now to print current date and time to console. 
            Console.WriteLine("Can you please give me a number?");//getting user Input.
            double Hours = Convert.ToDouble(Console.ReadLine());//converting user input to double as we will be doing arithmatic on it. 
            DateTime Now = DateTime.Now;//getting current date and time and assigning it to the variable Now
            DateTime Future = Now.AddHours(Hours);//adding the user input to the hours of current date and time. 
            Console.WriteLine("The time in " + Hours + " Hours from now will be... " + Future);//printing new date and time to console. 



            Console.ReadLine();
        }
    }
}
