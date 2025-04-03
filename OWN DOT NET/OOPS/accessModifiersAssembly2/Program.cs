using System;
using accessModifiersAssembly1; 

namespace accessModifiersAssembly2
{
    public class Assembly2DerivedClass : Assembly1BaseClass
    {
        public void TestCaseInDifferentAssemblyDerivedClass()
        {
            //not accessible
            //Console.WriteLine(privateVariable);
            //Console.WriteLine(internalVariable);

            //accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }
    public class Assembly2OtherClass
    {
        Assembly1BaseClass obj = new Assembly1BaseClass();

        public void TestAccessInOtherClassOfAssem2()
        {
            // not accessible
            //Console.WriteLine(obj.privateVariable);
            //Console.WriteLine(obj.protectedVariable);
            //Console.WriteLine(obj.internalVariable);
            //Console.WriteLine(obj.protectedInternalVariable);

            //accessible
            Console.WriteLine(obj.publicVariable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assembly2DerivedClass objAssem2Derived = new Assembly2DerivedClass();
            Console.WriteLine("Within Derived class of different assembly : ");
            Console.Write(new string('-', 50));
            Console.WriteLine();
            objAssem2Derived.TestCaseInDifferentAssemblyDerivedClass();


            Assembly2OtherClass objAssem2Other = new Assembly2OtherClass();
            Console.WriteLine("\n\nWithin other class of different assembly : ");
            Console.Write(new string('-', 50));
            Console.WriteLine();
            objAssem2Other.TestAccessInOtherClassOfAssem2();






            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
