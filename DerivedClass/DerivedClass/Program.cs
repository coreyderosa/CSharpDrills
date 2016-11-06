using System;

namespace DerivedClass
{
    class ClassA
    {
        public string myMethodA()
        {
            return "This method is in the base class";
        }
        public string myMethodB()
        {
            return "This method is also in the base class";
        }
    }

    class ClassB : ClassA
    {
        public string myInheritedClass()
        {
            return "This method is in the derived class";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassA methodA = new ClassA();
            ClassB methodB = new ClassB();

            methodA.myMethodA();
            methodA.myMethodB();
            methodB.myInheritedClass();
            methodB.myMethodA();

            Console.WriteLine("Class: {0}", methodA.myMethodA());
            Console.WriteLine("Class: {0}", methodA.myMethodB());
            Console.WriteLine("Class: {0}", methodB.myMethodA());
            Console.WriteLine("Class: {0}", methodB.myInheritedClass());
        }
    }


}