using System;

namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number : ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number : ");
                int y = int.Parse(Console.ReadLine());

                if (y == 1)
                {
                    return;  
                }
                int z = x / y;

                Console.WriteLine("The result is " + z);
                Console.WriteLine("End of the program");
            }
            //catch (Exception e) { 
            //    Console.WriteLine(e.Message);
            //}
            finally
            {
                Console.WriteLine("The finally block is executed"); 
            }
            Console.WriteLine("Enter any key to exit"); 
            Console.ReadKey(); 
        }
    }
}
