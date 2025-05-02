using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwelveDefaultArguments
{
    using System;

    class Program
    {
        // Method with default arguments
        static void Greet(string name = "Himanshu Kumar", string message = "Welcome!")
        {
            Console.WriteLine($"Hello {name}, {message}");
        }

        static void Main()
        {
            Greet();                            // Output: Hello Guest, Welcome!
            Greet("Kamlesh");                     // Output: Hello Alice, Welcome!
            Greet("Raghav", "Good to see you!");   // Output: Hello Bob, Good to see you!
        }
    }

}
