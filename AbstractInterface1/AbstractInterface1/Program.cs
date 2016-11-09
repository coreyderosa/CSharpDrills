using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface1
{
    
    public abstract class Dog
    {
        string name = "Fido"; //Interfaces cannot contain fields
        int dogYears = 3;

        //private access by default but can have another access modifier
        public void myDog() 
        {
            Console.WriteLine(name + "is " + dogYears + "years old in dog years");
        }

        
    public interface IDog
    {
            string name = "Fido"; //Interfaces cannot contain fields
            int dogYears = 3; //Interfaces cannot contain fields

            //public access by default but cannot be modified
            public void myDog()
        {
            Console.WriteLine(name + "is " + dogYears + "years old in dog years");
        }
            
    }






        static void Main(string[] args)

        {

        }
    }
}
