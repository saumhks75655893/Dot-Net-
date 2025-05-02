using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwentyTwoInterface
{
    interface Addition
    {
        int Add(int a, int b);
    }

    // Implement the interface
    class SimpleCalculator : Addition
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Addition calc = new SimpleCalculator();

            int num1 = 10;
            int num2 = 20;

            int result = calc.Add(num1, num2);

            Console.WriteLine($"Sum of {num1} and {num2} is: {result}");
        }
    }

}
