using System;
using System.Collections;

class LOOPS
{
    static void Main(string[] args)
    {
        ////for loop
        //for(int i = 0; i<=10; i++)
        //{
        ////Console.WriteLine(i); 
        //}





        ///*
        //    * 
        //    * * 
        //    * * * 
        //    * * * * 
        //    */
        //for (int i = 1; i <= 4; i++)
        //{
        //    for(int j=1; j<=i; j++)
        //{
        //    Console.Write("*");
        //}
        //    Console.WriteLine();
        //}






        //find the number of digit in the number 
        //string a;
        //int num;
        //int NumberOfDigit = 0;
        //int ReverseNumber = 0;
        //int b; 
        //Console.Write("Enter the number : ");
        //a = Console.ReadLine();
        //num = Convert.ToInt32(a);
        //int temp = num;
        //while (temp > 0)
        //{
        //    b = temp % 10; 
        //    ReverseNumber = ReverseNumber * 10 + b;
        //    NumberOfDigit += 1;
        //    temp = temp / 10; 
        //}
        //Console.WriteLine("Number of Digit is : "+NumberOfDigit); 
        //Console.WriteLine("Reverse of the number {0} is : {1} ",num,ReverseNumber);




        ////find the max and min value in the array
        //int[] arr = {14, 21, 3, 94, 565, 61, 10, 234,21,145,25};
        //int min = arr[0];
        //int max = arr[0]; 
        //for (int i = 0; i < arr.Length; i++) {
        //    if (min > arr[i]) { 
        //        min = arr[i];
        //    }
        //}
        //Console.WriteLine("Min value of the array is : {0}", min);
        //for (int i = 0; i < arr.Length; i++) {
        //    if (max < arr[i]) { 
        //        max = arr[i];
        //    }
        //}
        //Console.WriteLine("Max value of the array is : {0}", max); 





        ////factorial of given number 
        //String a;
        //int num, value = 1; 
        //Console.Write("Enter the number : "); 
        //a = Console.ReadLine();
        //num = Convert.ToInt32(a);
        //for (int i = 1; i <= num; i++) {
        //    value = value * i; 
        //}
        //Console.WriteLine("The value is : {0}", value); 






        //// Fibonacci series 
        //String a;
        //int num;
        //Console.Write("Enter the number : ");
        //a = Console.ReadLine();
        //num = Convert.ToInt32(a);

        //int x=0, y=1, fibo;
        //Console.Write("The fibonacci series of {0} is : ", num + " "); 
        //for (int i = 0; i < num; i++) {
        //    fibo = x + y; 
        //    Console.Write(x + " ");
        //    x = y;
        //    y = fibo;
        //}






        //// Perfect number check
        //String a;
        //int num,perfectNumber=0;
        //Console.Write("Enter the number : ");
        //a = Console.ReadLine();
        //ArrayList arr = new ArrayList(); 
        //num = Convert.ToInt32(a);

        //for (int i = 1; i < num; i++) { 
        //    if(num % i == 0)
        //    {
        //        arr.Add(i);
        //        perfectNumber = perfectNumber + i; 
        //    }
        //}
        //Console.Write("{ "); 
        //foreach(int val in arr)
        //{
        //    Console.Write(val + " ");
        //}
        //Console.Write("}");
        //Console.WriteLine();
        //Console.WriteLine("num : "+num);
        //Console.WriteLine("perfectNumber : "+perfectNumber);

        //if (num == perfectNumber) {
        //    Console.WriteLine("{0} is a perfect number!", num); 
        //}
        //else
        //{
        //    Console.WriteLine("{0} is not a pefect number!", num); 
        //}


    }
}
