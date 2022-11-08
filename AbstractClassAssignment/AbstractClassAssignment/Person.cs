using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //this is an abstract class meaning it cant be instatiated it can only be inherited from
    public abstract class Person
    {
        public string FirstName { get; set; }// setting first property
        public string LastName { get; set; }//setting second property

        public abstract void SayName(); //this is an abstract method. it does not have a function but it makes it imparative that any inheriting class must have a method with the same name. 
    }
}
