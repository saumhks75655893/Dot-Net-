using System;

namespace accessModifiersAssembly1
{
    public class Assembly1BaseClass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protectedInternalVariable = "protected internal";
        public string publicVariable = "public"; 

        public void TestAccessInSameClass()
        {
            // within same class : accessible all 
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }
    public class Assembly1DerivedClass : Assembly1BaseClass
    {
        public void TestAccessInDerivedClass()
        {
            // within derived class : not accessible
            //Console.WriteLine(privateVariable);

            // within derived class : accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }

    public class Assembly1OtherClass
    {
        Assembly1BaseClass obj = new Assembly1BaseClass();

        public void TestAccessInOtherClass()
        {
            // not accessible
            //Console.WriteLine(obj.privateVariable);
            //Console.WriteLine(obj.protectedVariable);

            //accessible
            Console.WriteLine(obj.internalVariable);
            Console.WriteLine(obj.protectedInternalVariable);
            Console.WriteLine(obj.publicVariable);
        }                     
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly1BaseClass objTest = new Assembly1BaseClass();
            Console.WriteLine("Within same class ");
            Console.Write(new string('-', 50));
            Console.WriteLine();
            objTest.TestAccessInSameClass();

            Assembly1DerivedClass objDerived = new Assembly1DerivedClass();
            Console.WriteLine("\n\nWithin derived class ");
            Console.Write(new string('-', 50));
            Console.WriteLine();
            objDerived.TestAccessInDerivedClass();

            Assembly1OtherClass objOther = new Assembly1OtherClass();
            Console.WriteLine("\n\nWithin other class ");
            Console.Write(new string('-', 50));
            Console.WriteLine();
            objOther.TestAccessInOtherClass();










            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
