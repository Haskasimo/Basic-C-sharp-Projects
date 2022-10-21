using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAsign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int UserNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Let's add 10 to your number! Your answer would be " + Numbers.Add10(UserNumber));
            Console.WriteLine("Great now let's take 5 away from your number. Your answer would be " + Numbers.Sub5(UserNumber));
            Console.WriteLine("Ok! Last one, what would your number be if we divided it in half?...Your number would be " + Numbers.div2(UserNumber));
            Console.ReadLine();
        }
    }
}
