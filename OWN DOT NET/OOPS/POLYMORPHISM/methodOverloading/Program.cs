using System;

internal class Program
{
    //method overloading 
    class methodOverloading
    {
        public void processData(int a, int b)
        {
            int c = a + b; 
            Console.WriteLine("Result (add) = "+c);
        }

        public void processData(int a, int b, int c)
        {
            int mul = a * b * c;
            Console.WriteLine("Result (multiply) = " + mul); 
        }

        public void processData(int a, string b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}"); 
        }
    }
    static void Main(string[] args)
    {
        methodOverloading methodOverloading = new methodOverloading();
        methodOverloading.processData(40,59);
        methodOverloading.processData(10, 40, 14);
        methodOverloading.processData(10, "Himanshu Kumar"); 
        methodOverloading.processData(10, "10"); 
    }
}

