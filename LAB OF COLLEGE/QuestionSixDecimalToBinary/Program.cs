using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSixDecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decNumber =8, binaryNumber = 1;
            int temp1 = decNumber;
            while(decNumber > 1)
            {
                int temp = decNumber % 2;
                binaryNumber = binaryNumber * 10 + temp;
                decNumber = decNumber / 2;
            }

            Console.WriteLine($"The binary number of {temp1} is {binaryNumber}"); 

        }
    }
}
