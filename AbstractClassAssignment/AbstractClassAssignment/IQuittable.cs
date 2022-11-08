using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //this is a interface class. This can not be instatiated, but can be inherited. 
    interface IQuittable
    {
        void Quit();//this is an abstract method inherited from IQuittable. It wont do anything, but it will force the class inheriting that is must inclued this method by name. 
    }
}
