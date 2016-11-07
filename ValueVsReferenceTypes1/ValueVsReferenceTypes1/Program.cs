using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7; //value type stores the data in the stack
            int[] x = new int[7]; //reference type store the data in the heap
        }
    }
}
