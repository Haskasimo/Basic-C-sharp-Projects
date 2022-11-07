using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide DivTwo = new Divide();

            Console.WriteLine("Hello, Please give me a number \n I'm going to divide it by two. ");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            Divide.DivideBy2(UserNumber);

            int Number1;
            int Number2;
            Divide.OutNum( out Number1);
            Divide.OutNum(out Number1, out Number2);
            Console.ReadLine();
        }
    }
}
