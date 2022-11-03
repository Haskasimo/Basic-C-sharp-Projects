using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    public class IntOne
    {
        public int ChoiceOne(int UserNumber)
        {
            int AddOne= UserNumber + 15;
            return AddOne;
        }
        public int ChoiceOne(decimal UserNumber2)
        {
            decimal X = UserNumber2 * 5;
            int UserResult = Convert.ToInt32(X);
            return UserResult;
        }
        public int ChoiceOne(string userstring)
        {
            int changestring = Convert.ToInt32(userstring) + 10;
            return changestring;
        }
    }
}
