using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string food = "olives";
            if (food != "pork")
                {
                Console.WriteLine("You did not eat pork");
            }
            else
            {
                Console.WriteLine("You have a strange diet");
            }


            int num1 = 14;
            int num2 = 28;

            string result = num1 > num2 ? "number 1 is greater than number 2" : "number1 is not greater than number 1";
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
