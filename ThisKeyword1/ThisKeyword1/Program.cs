using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword1
{
    class Program
    {
        public string a;
        public string b;

        static void withoutThis(string a, string b)
        {
            a = a; 
            b = b;
        }

         public void withThis(string a, string b)
        {
            this.a = a; 
            this.b = b;
        }
    }
}
