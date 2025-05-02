using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwoPrimeNumber
{
    class PrimeNumberChecker
    {
        public int CheckPrime(int num)
        {
            if (num <= 0) {
                return 0;
            }

            for(int i=2; i<num; i++)
            {
                if(num % i == 0)
                {
                    return 0;
                }
            }

            return 1;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : "); 
            int num = int.Parse(Console.ReadLine());
            PrimeNumberChecker pnc = new PrimeNumberChecker();
            int getValue = pnc.CheckPrime(num);
            if( getValue != 0 )
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number"); 
            }
        }
    }
}
