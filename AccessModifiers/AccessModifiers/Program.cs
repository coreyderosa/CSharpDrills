using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    ///
    /////////////// Public ////////////////////////
    ///
    class Public
    {
        public int x; //access is not restricted
    }
    /// 
    /////////////// Protected ////////////////////////
    /// 
    class ProtectedA
    {
        protected int x = 5; // Protected within this class or any class that inherits this class
    }

    class ProtectedB : ProtectedA
    {
        static void Main()
        {
            ProtectedA a = new ProtectedA();
            ProtectedB b = new ProtectedB();

            a.x = 10;//x is protected within ProtectedA so it cannot be accessed here
            b.x = 10;//x access is granted since ProtectedB is a derived class of ProtectedA
        }
        
    }

}
///
/////////////////Internal ////////////////////
///

//File1.cs
public class File1
{
    internal int x;
}

//File2.cs
public class File2
{
    static void Main()
    {
        File1 myFile = new File1();
        File1.x = 7; //this will throw an error since the variable x is internal in File1.cs
    }
    
}

///
/////////////////// Private ///////////////////
///

 class privateA
{
    private int x = 5;

    public int pA()
    {
        return x;
    }
}

class privateAccess
{
    privateA a = new privateA();
    int y = a.pA; //This will throw an error since x is has private access
}



sealed class A
{
    //some code here
}

class B : A //This is not allowed because class A is sealed
{
    ///some code here
}