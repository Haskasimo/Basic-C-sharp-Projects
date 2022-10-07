using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! Let's play with some simple math operations. \n First, choose a number we can play with.");
            string userNumber = Console.ReadLine();
            int Number1 = Convert.ToInt32(userNumber);
            Console.WriteLine("Great! Now let's multiply it by 50!");
            int Product = 50 * Number1;
            Console.WriteLine(Product);
            Console.WriteLine("Great! Now choose another number.");
            string user2 = Console.ReadLine();
            int Number2 = Convert.ToInt32(user2);
            Console.WriteLine("Great! Now let's add 25 to it. Now the number is...");
            int Total = 25 + Number2;
            Console.WriteLine(Total);
            Console.WriteLine("Ok now choose a number and let's divide it by 15.5");
            string Userdiv = Console.ReadLine();
            double DivNum = Convert.ToDouble(Userdiv);
            double Quotient = DivNum / 12.5;
            Console.WriteLine(Quotient);
            Console.WriteLine("Great now lets see if the number I choose is greater than the number you chose. Pick a number!");
            string userNumberGreater = Console.ReadLine();
            int NumberGreater = Convert.ToInt32(userNumberGreater);
            bool Isgreater = NumberGreater > 50;
            string Greater = Isgreater.ToString();
            Console.WriteLine(Greater);
            Console.WriteLine("Wonderful! Now let's divide a number you choose by 7 and see what the remainder is \n Go ahead and pick a number!");
            string UserRemainder = Console.ReadLine();
            int RemainNum1 = Convert.ToInt32(UserRemainder);
            int RemainNum2 = 7;
            int Remainder = RemainNum1 % RemainNum2;
            Console.WriteLine("Your remainder is..");
            Console.WriteLine(Remainder);
            Console.ReadLine();

            



        }
    }
}
