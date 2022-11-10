using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genarics1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> Things = new Employee<string>();//instantiates an object baised on the Employee class with a string data type.  
            Things.Thing = new List<string>() { "Medatate", "Play Music", "Write", "Draw Plans", "Meeting" }; //creating a new list objest from the employee object targeting "Thing" as its format. 

            Employee<int> Things2 = new Employee<int>();//as with the above, this creates an Employee object but this time with a data type of int.  
            Things2.Thing = new List<int>() { 10, 14, 30, 60, 120 };//instatiates the object targeting "Thing" from the employee class. This will use the framework of the Employee class to create the List

            for( int i=0; i < Things.Thing.Count(); i++ )//creates a loop that will run for how many indecies are in the Things List. 
            {
                Console.WriteLine(" To do: " + Things.Thing[i] + " " +  Things2.Thing[i]+ " min");//write both objects at the matching indecies to the console. 
            }
            Console.ReadLine();

      

        }

    }



        
    }
