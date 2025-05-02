using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFiveSwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 30;
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);

            num1 = num1 + num2; 
            num2 = num1 - num2;
            num1 = num1 - num2; 

            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = "+ num2);


        }
    }
}
