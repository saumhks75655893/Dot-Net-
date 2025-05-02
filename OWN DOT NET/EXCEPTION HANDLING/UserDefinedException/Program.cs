using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// userdefined exception with namespace UserDefinedException
namespace UserDefinedException
{
    public class DivideByOddNumberException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Numerator can not be an odd number";
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number first");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a number second");
        int number2 = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (number % 2 > 0)
            {
                // here we use the userdefined exception within the try block 
                throw new UserDefinedException.DivideByOddNumberException();
            }
        }
        // here we catch the userdefined exception
        catch (ApplicationException ae)
        {
            Console.WriteLine(ae.Message);
        }

        try
        {
            int z = number / number2;
            Console.WriteLine("The result is: " + z);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("End of the program");

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}

