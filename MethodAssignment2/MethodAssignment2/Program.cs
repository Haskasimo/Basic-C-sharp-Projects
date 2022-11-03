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
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            IntOne Obj1 = new IntOne(); //creating object
            Console.WriteLine(Obj1.ChoiceOne(UserNumber));

            Console.WriteLine(" Great now give me a number with a decimal. I will multiply it by 15.5 and give you a whole number back.");
            decimal UserNumber2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Great your result is  " + Obj1.ChoiceOne(UserNumber2));

            Console.WriteLine("Wonderful! Now can you once again give me a number?.. no decimal this time.");
            string UserString = Console.ReadLine();
            Console.WriteLine("Great! Now let me just add 10 to your number. " + Obj1.ChoiceOne(UserString));//why will the method not convert to a int?

            
            Console.ReadLine();
        }
    }
}
