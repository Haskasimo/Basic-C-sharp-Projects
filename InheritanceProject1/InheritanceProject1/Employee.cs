using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1
{
    public class Employee : Person//this inherits the properties and methods from the Person Class
    {
        public int Id { get; set; }

        public override void SayName()

        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: {0}", FullName);
        }
    }

  
}
