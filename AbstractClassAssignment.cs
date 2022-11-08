using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1
{
    class Program
    {
        //inheritance is borrowing properties from another class so you don't have to rewrite all the code.  
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" } ;//this is assigning values to the object using properties inherited from the Person class. 

            employee.SayName();//this is a super class method. this is calling a method that has been inheritaed from another class. In this case the Person class.
            Console.ReadLine();
        
            

        }
    }
}
