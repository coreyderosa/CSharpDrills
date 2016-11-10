using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    
    public delegate void DelegateExample(string Example); 

    class DelegateClass
    {
        public static void Main() 
        {
            DelegateExample ex = new DelegateExample(Derp);
            ex("Delegates are confusing");
        }
              
        public static void Derp(string delEx)
        {

            Console.WriteLine(delEx);

            Console.Read();

        }
    }
}
