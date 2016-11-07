using System;
using System.IO;
using System.Diagnostics;
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
            catch(Exception ex)
            {
                string path = "D:\\Documents\\TryCatchFinally1.txt"; //location of error log file
                string error = string.Format("The following error has occured: {0}", ex);
                File.WriteAllText(path, error); //This will create a txt file with the error details
                Console.WriteLine("The error has been logged!");
            }
            finally
            {
                Console.WriteLine("The try/catch/finally is complete!");
            }
        }
    }
}
