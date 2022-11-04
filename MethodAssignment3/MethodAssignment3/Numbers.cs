using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment3
{
    public class Numbers
    {
        //in this claass we will set up the method to have an optional paramater. 
        public int Addition(int Number1, int Number2 = 20) // Setting up the Method Addition it will take in two paramaters to run it. The value of the first number is given to us by the user,
                                                           // and the Number2 variable will have a defult value of 20 if the user does not want to give us a number. we use the = sign to establish a defult value, this is called an optinal paramater. 
        {
            int Plus35 = Number1 + Number2 + 35;
            return Plus35;
        }
    }
}
