using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class Math
    {
        public void Multiply(int Choice1, int Choice2)//The Void method can run like a regular method however it can not return a value.  
        {
            int multiply1 = Choice1 * 25;//because this is a void method it can not store values for other methods to use,  it can really only disply the values in the method to the console. 
            Console.WriteLine("Number one times 25 is " + multiply1);
            Console.WriteLine(" your second number was  " + Choice2);
        }
    }
}
