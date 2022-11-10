using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{

    //This program uses operator overloading. instead of the operator just working in a 
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();//creating object 1 from the Employee class
            employee1.Id = 1283;
         

            Employee employee2 = new Employee();//creating object 2 from the employee class
            employee2.Id = 13405;

            Console.WriteLine(employee1 == employee2);// this compares employee1 to employee but instead of compareing the object names, it triggers the operator overload and runs the compare method in the employee class which targets the Id instead of the name. 
            Console.ReadLine();
        }
    }
}
