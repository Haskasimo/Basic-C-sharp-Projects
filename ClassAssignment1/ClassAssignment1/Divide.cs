using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    class Divide
    {
        public static void DivideBy2(int UserChoice)
        {
            int divide2 = UserChoice / 2;
            Console.WriteLine(divide2);
        }

        public static void OutNum(out int Number1)
        {
            Number1 = 30;
            Number1 += Number1 ;
            Console.WriteLine("My number doubled is  " +Number1);
        }

        public static void OutNum(out int Number1, out int Number2)
        {
            Number1 = 30;
            Number1 += Number1;

            Number2 = 25;
            Number2 += Number2;
            Console.WriteLine("The first number doubled is {0}" + Number1);
            Console.WriteLine("The Second number doubled is {0} " + Number2);
        }
    }
}
