using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwentyFiveMethodOverloadingTypeBased
{
    class Operations
    {
        // Add method for integers
        public void Combine(int a, int b)
        {
            Console.WriteLine("Integer Sum: " + (a + b));
        }

        // Add method for doubles
        public void Combine(double a, double b)
        {
            Console.WriteLine("Double Sum: " + (a + b));
        }

        // Add method for strings (concatenation)
        public void Combine(string a, string b)
        {
            Console.WriteLine("String Concatenation: " + (a + b));
        }
    }

    class Program
    {
        static void Main()
        {
            Operations op = new Operations();

            op.Combine(5, 10);              // int version
            op.Combine(5.5, 4.5);           // double version
            op.Combine("Hello, ", "World"); // string version
        }
    }

}
