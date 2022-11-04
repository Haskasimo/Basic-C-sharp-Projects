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
        {
            Numbers Numb = new Numbers();

            Console.WriteLine("Hello! Lets do some math. \n First I need a number can you give me one?");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Great! now we need another number! \n Don't worry, if you cant think of one I can think of one for you. ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Great! Now lets add the two number and 35 together! \n Our nue number is   " + Numb.Addition(Number1, Number2));

            }
            catch
            {
                Console.WriteLine("Great! Now lets add the two number and 35 together! \n Our nue number is   " + Numb.Addition(Number1));

            }




            Console.ReadLine();
        }
    }
}
