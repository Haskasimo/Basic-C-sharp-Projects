using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAsign2
{
    public class Numbers
    {
        public static int Add10(int UserNumber)//public static means that we dont have to create an object in order to make a function/method. THis method is named Add10 and its paramater is the users input. 
        {
            int AddResult = UserNumber + 10; //this method will create a new variable calles AddResult that is the result of adding the users input by 10. To make this method work we must return the value so that AddResult has value
            return AddResult;
        }
        public static int Sub5(int UserNumber)
        {
            int SubResult = UserNumber - 5;
            return SubResult;
        }

        public static int div2(int UserNumber)
        {
            int DivResult = UserNumber / 2;
            return DivResult;
        }
    }
}
