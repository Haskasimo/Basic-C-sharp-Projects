using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_CatchAssignment
{
    //this is a special exception for a certin situation in the code. instead of a generic exception we can trigger a specail code if an arror occurse.
    public class AgeException : Exception//this is inheriting from Exception. 
    {
        public AgeException()//initilized a new instance of the class
            : base() { }
        public AgeException(string message)//creates paramaters for the exception to execute. 
            : base (message) { }

    }
}
