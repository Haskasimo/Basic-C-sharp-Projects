using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject1
{
   public abstract class Person// this is a basic class that other methods can esily inherit from
    {
        //the properties of the class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //the behavior of the class. 
        public abstract void SayName();//this is a abstract method and it will not actually do anything, but it staters that nay class inheriting must have a SayName Method.  
        
        
    }
}
