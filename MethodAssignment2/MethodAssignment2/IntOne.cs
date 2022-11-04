using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    public class IntOne
    {
        public int ChoiceOne(int UserNumber)// This is the original method. First we want the data type you want to return (Public int "name of Method")
                                            // and then the data type it is taking in (int "idName".) 
        {
            int AddFifteen= UserNumber + 15;//if the data type passed in is an intager this method will run. 
            return AddFifteen;
        }
        // this creates an overload that if the user types in a decimal it will run this overload instead. it takes in a decimal and returns an int.
        public int ChoiceOne(decimal UserNumber2) //return data type int (taking in datatype decimal)
        {
            decimal X = UserNumber2 * 15; //math operations on user input
            int UserMulti = Convert.ToInt32(X);//converts the users new number to an int
            return UserMulti;//returns number as int
        }
        //This creates an overload that if the data type being passed to the method is a string, this will trigger. 
        public int ChoiceOne(string userstring)//returning data type int (taking in data type string)
        {
            int changestring = Convert.ToInt32(userstring) + 10;//converts data type to int and then doeas the math operation
            return changestring;//returns an int 
        }
    }
}
