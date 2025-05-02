using System;

namespace FirstQuestionFibonacciSeries
{
    // without using recursion
    class FibonacciSeriesWithoutUsingRecursion
    {
        int x = 0, y = 1, fibo = 0,num;

        public void FibonacciWithoutRecursoin()
        {
            Console.Write("Enter the number :"); 
            num = int.Parse(Console.ReadLine());
            Console.Write("Fibonacci Series : "); 
            for(int i=0; i < num; i++)
            {
                fibo = x + y;
                Console.Write(x + " ");
                x = y;
                y = fibo; 
            }
        }
    }    // with using recursion
    class FibonacciSeriesWithUsingRecursion
    {
        int x = 0, y = 1, fibo = 0, incNum;
        public void FibonacciWithRecursoin(int num)

        {

            if(incNum != num)
            {
                fibo = x + y;
                Console.Write(x + " ");
                x = y; 
                y = fibo;
                incNum++; 
                FibonacciWithRecursoin(num); 
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //without recursion
            FibonacciSeriesWithoutUsingRecursion fwr = new FibonacciSeriesWithoutUsingRecursion();
            fwr.FibonacciWithoutRecursoin();
            Console.WriteLine(); 
            Console.WriteLine(); 
            Console.WriteLine(); 


            //with recursion
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            FibonacciSeriesWithUsingRecursion fwir = new FibonacciSeriesWithUsingRecursion();
            Console.Write("Fibonacci Series : ");
            fwir.FibonacciWithRecursoin(num);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
