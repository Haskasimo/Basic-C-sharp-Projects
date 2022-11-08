using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        //inheritance is borrowing properties from another class so you don't have to rewrite all the code.  
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" } ;//this is assigning values to the object using properties inherited from the Person class which is an abstract class. 

            employee.SayName();//calling the method that was ovridden in the Employee class 
            Console.ReadLine();
        
            

        }
    }
}
