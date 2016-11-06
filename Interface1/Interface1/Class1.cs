using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    class Class1 : Interface1, Interface2 //can implement more than on interface
    {
        void Interface1.DoInterface1Stuff() //must implement all itmes of Interface1
        {
            throw new NotImplementedException();
        }

        void Interface2.DoInterface2Stuff() //must implement all itmes of Interface1 
        {
            throw new NotImplementedException();
        }

        void Interface1.DoMoreInterface1Stuff() //must implement all itmes of Interface2
        {
            throw new NotImplementedException();
        }

    }
}
