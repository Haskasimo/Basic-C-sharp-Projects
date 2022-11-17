using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsApp
{
    class Animal
    {
        public string Type;
        public string Breed;

        public Animal(string type) : this(type, "Any" )//chaining two constructors together so that if the user does not enter a breed it will assign the value of unkown to it. 
        {

        }

        public Animal(string Type, string Breed) //This is a cunstructor, this will take inputs from the main program and automaticall assign it to propertiess of the class. 
        {
            this.Type = Type;
            this.Breed = Breed;
        }
    }
}
