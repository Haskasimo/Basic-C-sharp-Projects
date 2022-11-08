using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{

    //This class is using an abstract class as the main class to inheris from
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable iquit = new Employee();
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //instantiates the object employee with properties inherited from the Person Class 

            employee.SayName();//calles override method in the Employee class
            iquit.Quit();
            Console.ReadLine();
        }
    }
}
