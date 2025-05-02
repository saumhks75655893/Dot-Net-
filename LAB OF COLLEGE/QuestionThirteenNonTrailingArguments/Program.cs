using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThirteenNonTrailingArguments
{
    class Program
    {
        // Overloaded method with both parameters
        static void Show(string message, int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(message);
        }

        // Overload with default value for 'message'
        static void Show(int count)
        {
            Show("Hello", count);  // Default for 'message'
        }

        static void Main()
        {
            Show(3);                 // Uses default message: "Hello"
            Show("Hi there!", 2);    // Custom message
        }
    }

}
