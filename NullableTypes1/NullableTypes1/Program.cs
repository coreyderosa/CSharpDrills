using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool? vote = null;

            if (vote == true)
            {
                Console.WriteLine("Awesome, you voted!");
            }
            else if (vote == false)
            {
                Console.WriteLine("Why didnt vote?!");
            }
            else
            {
                Console.WriteLine("Did you vote or not?!");
            }
            Console.Read();
        }
    }
}
