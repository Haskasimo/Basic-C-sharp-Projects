using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genarics1
{
    public class Employee<T> //this class is set as a genaric class by put <T> at the end of the Class Id. 
        //A genaric class will not have values but be a basic framework that you can use to pass values into. This makes it so that sevral different programs can use it even if the data type is different. 
    {
        public List<T> Thing { get; set; }//This set up a basic empty list "Thing" with no set data Type. a data typewill have to be instatiated later on in order to use it.  


        
          




    }




}
