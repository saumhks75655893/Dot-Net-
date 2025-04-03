using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateAndStaticConstructor
{

    public class PrivateConstructor
    {
        //private instance variable
        private static int counter;


        //private constructor
        private PrivateConstructor()
        {
            counter = 20; 
        }
        
        //static constructor
        static PrivateConstructor()
        {
            counter = 20; 
        }

        //public constructor with private instance variable
        public PrivateConstructor(int counter1)
        {
            counter = counter + counter1; 
        }

        //GetCounter method
        public static int GetCounter()
        {
            return ++counter; 
        }

        // nested class
        public class NestedExample
        {

            //nested class method
            public void Test()
            {
                //internal instance
                PrivateConstructor pc = new PrivateConstructor();

                Console.WriteLine(counter); 
            }
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            // external instance : not possible for private constructor
            //PrivateConstructor pc = new PrivateConstructor(); 
            //Console.WriteLine($"Counter Value : {PrivateConstructor.GetCounter()}");

            // public constructor with private instance variables
            PrivateConstructor pc = new PrivateConstructor(10);
            Console.WriteLine($"Counter Value : {PrivateConstructor.GetCounter()}");
        }
    }
}
