using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment
{
    public struct Number
    {
        public decimal Amount { get; set; }//creating a property of a decimal. because a struct is a value type this can not be null. 
    }
}
