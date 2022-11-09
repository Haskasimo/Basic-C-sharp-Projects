using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee
    {
        //setting up the properties for the Employee class. 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        //This create an operator overload. Which means is a comparison is made in the main program it will trigger this method instead. 
        //because this is a comparison looking for a true fales statement, the data type is set as bool.
        //to overload an operator, you write operator and then the operator you want to overload (+ - / * == !== < >)
        public static bool operator ==(Employee employee1, Employee employee2) //(we want to compare two objects but we want them taken from the employee class using its paramaters)
        {
            return employee1.Id == employee2.Id;//we need to return a value of true or false. Instead of compare the entire object of employee1 to employee2, we are only going to target the Id. 
        }

        //Whenever you are using comparison operators you must write it in pairs. If you make an override for == you must also make it for !==, same with < and >,  <= and >=
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
