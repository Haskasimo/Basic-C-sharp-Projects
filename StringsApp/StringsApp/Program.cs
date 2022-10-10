using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play with strings \n Let's first concatenate." );

            Console.WriteLine(". \n. \n. \n.");

            string quote = "Carpe diem." + " Seize the day, boys." + " Make your lives extraodinary."; //to add strings together put the "+" inbetween each string.
            Console.WriteLine(quote);

            Console.WriteLine(". \n. \n. \n.");// the \n will write anything after it on a new line. 

            string upper = "Let's change to uppercase!";
            Console.WriteLine(upper.ToUpper()); //you can change the value of a sting to display as all uppercase if you add .ToUpper after the variable and simmalerly to .ToLower
            Console.WriteLine(". \n. \n. \n.");

            Console.WriteLine("Let's use StringBuilder to write a poem.");
            Console.WriteLine(". \n. \n. \n.");
           
            //If you don't want to allocate a ton of memory to store lots of different strings, you can use StringBuilder which is a dynamic object that can expand and collapse easily.
            StringBuilder sb = new StringBuilder("The wind was a torrent of darkness among the gusty trees.");// the .Append will attach following string to the string already stored inside the StringBuilder object sb. 
            sb.Append("\nThe moon was a ghostly galleon tossed upon cloudy seas.");
            sb.Append("\nThe road was a ribbon of moonlight over the purple moor, ");
            sb.Append("\nAnd the highwayman came riding");
            sb.Append("\nRiding, riding,");
            sb.Append("\nThe highwayman came riding, up to the old inn - door.");
            Console.WriteLine(sb);

            Console.ReadLine();


        }
    }
}
