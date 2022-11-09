using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person, IQuittable//this is inherating from the base class Person and the interface iQuittable
    {
        public override void SayName()//the override method takes the method from its inherited class but changes it to have new paramaters and function. 
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name : {0}", FullName);
        }
        public void Quit()//this is an inherated method from IQuittable and it must be used in the class. 
        {
            throw new NotImplementedException();//because there is no method to run yet, we will throw an error to check that the method did indeed try to run. 
        }
    }
}
