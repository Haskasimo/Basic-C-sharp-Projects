using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Number number = new Number();//creating a new object from the struct Numbers. Structs are value types so they can really only handle int, boolean, enums, and day/time. Things that need value
            number.Amount = 13.7m;//to establish that this data type is a decimal you need to add an m to the end. 

            Console.WriteLine(number.Amount);//if you only reference number it will print the struct information, you must include the property of amount with it as struct will not overwrite data in certain places. 
            Console.ReadLine();

        }
    }
}
