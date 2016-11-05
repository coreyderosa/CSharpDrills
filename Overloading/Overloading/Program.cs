using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDrill1
{
    class Program
    {

        public class Plane
        {

            public void Fly(string a)
            {
                Console.WriteLine("Where have you flown this year? ");
                a = Console.ReadLine();
                Console.WriteLine("Wow, you have flown to " + a + " this year!");
            }

            public void Fly(int numberOfFlights)
            {
                for (int i = 0; i < numberOfFlights; i++) ;
            }
        }

        static void Main()
        {
            Plane myPlane = new Fly();
            myPlane.Fly("Brazil");
            myPlane.Fly(5);
        }
    }
}


