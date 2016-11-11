using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    class DelegateClass
    {
        public delegate void DelegateExample();

        public static void Main()
        {
            DelegateExample ex1, ex2, ex3, ex4;
            ex1 = new DelegateExample(Derp1);
            ex2 = new DelegateExample(Derp2);
            ex3 = ex1 + ex2; //this will show both functions below
            ex4 = ex1 + ex2 - ex1; //this will only show the Derp2 function
            ex3();
            ex4();
        }                    

        public static void Derp1()
        {
            Console.WriteLine("Multicast Delegate 1");
        }

        public static void Derp2()
        {
            Console.WriteLine("Multicast Delegate 2\n");
        }
        
    }
    
}
