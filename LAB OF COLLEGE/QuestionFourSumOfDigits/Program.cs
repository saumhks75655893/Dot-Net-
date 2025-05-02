using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFourSumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sumOfDigit = 0;
            Console.Write("Enter the Number : "); 
            num = int.Parse(Console.ReadLine());
            int temp = num; 
            while(temp > 0)
            {
                int temp1 = temp % 10; 
                sumOfDigit = sumOfDigit + temp1;
                temp = temp / 10; 
            }

            Console.WriteLine($"The sum of the digits of {num} is {sumOfDigit}");
        }
    }
}
