using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThreeFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact=1; 
            Console.Write("Enter the Number : "); 
            int num = int.Parse(Console.ReadLine());
            for(int i=1;  i<=num; i++)
            {
                fact = fact * i; 
            }

            Console.WriteLine($"The factorial of {num} is {fact}");
        }
    }
}
