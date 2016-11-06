using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] try1 = new string[3]; //0,1,2
                string a = try1[4]; //referring to 3 which is not in array
            }
            catch
            {
                Console.WriteLine("There is an error!");
            }
            finally
            {
                Console.WriteLine("The try/catch/finally is complete!");
            }
        }
    }
}
