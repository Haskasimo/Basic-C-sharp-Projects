using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1
{
   public class Person// this is a basic class that other methods can esily inherit from
    {
        //the properties of the class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //the behavior of the class. 
        public void SayName()//this is a void method and it will not return value, it will store information that can be printed to the console. 
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: {0}", FullName);
        }
    }
}
