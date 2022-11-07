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
           //this program uses out paramaters so no values really are needed for the method to work. the values are included in the method and can be called on with the "out". 

            Console.WriteLine("Hello, Please give me a number \n I'm going to divide it by two. ");
            int UserNumber = Convert.ToInt32(Console.ReadLine());

            Divide.DivideBy2(UserNumber);

            int Number1;// this will make a variable but will not have any value. 
            int Number2;
            Divide.OutNum( out Number1);//calling on the method using the out paramater where no value is passed to the method but the method will pass out a value.
            Divide.OutNum(out Number1, out Number2);//this triggers the overload using two numbers instead of one. 
            Console.ReadLine();
        }
    }
}

