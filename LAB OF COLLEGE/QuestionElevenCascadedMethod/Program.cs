using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionElevenCascadedMethod
{
    class Calculator
    {
        private int result = 0;

        public Calculator Add(int value)
        {
            result += value;
            return this; // return current object for chaining
        }

        public Calculator Subtract(int value)
        {
            result -= value;
            return this;
        }

        public Calculator Multiply(int value)
        {
            result *= value;
            return this;
        }

        public void Display()
        {
            Console.WriteLine("Result: " + result);
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            // Cascaded method calls
            calc.Add(10)
                .Subtract(3)
                .Multiply(4)
                .Display();  // Output: Result: 28
        }
    }

}
