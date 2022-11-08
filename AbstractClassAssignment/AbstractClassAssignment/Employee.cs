using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person, IQuittable
    {
        public override void SayName()//the override method takes the method from its inherited class but changes it to have new paramaters and function. 
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name : {0}", FullName);
        }
        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
