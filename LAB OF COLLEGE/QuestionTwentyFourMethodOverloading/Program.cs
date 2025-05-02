using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwentyFourMethodOverloading
{
    class Calculator
    {
        // Method with 1 argument
        public void Add(int a)
        {
            Console.WriteLine("Sum: " + (a+a));
        }

        // Method with 2 arguments
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        // Method with 3 arguments
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum: " + (a + b + c));
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            calc.Add(5);             // Calls method with 1 argument
            calc.Add(5, 10);         // Calls method with 2 arguments
            calc.Add(5, 10, 15);     // Calls method with 3 arguments
        }
    }

}
