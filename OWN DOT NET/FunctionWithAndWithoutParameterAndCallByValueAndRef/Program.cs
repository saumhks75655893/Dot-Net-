using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FunctionWithAndWithoutParameterAndCallByValueAndRef
{
        
    // simple function example
    public void func()
    {
        Console.WriteLine("This is the simple function and can also called with parameter function."); 
    }

    // without parameter function
    public void func1()
    {
        int a = 10, b = 20;
        int result = a + b; 
        Console.WriteLine("Result is : "+result);
    }

    // with parameter functions 

    public void func2(int a, int b)
    {
        for(int i=1; i<=a; i++)
        {
            Console.WriteLine($"{b} x {i} = {b * i}"); 
        }
    }

    //funtion with return statement 

    public int mul(int a, int b)
    {
        return a * b;
    } 

    // call by value function 
    
    public void func3(int val)
    {
        val = val + 10;
        Console.WriteLine("Value in the called function is : " + val); 
    }

    // call by reference function

    public void func4(ref int val)
    {
        val = val + 10;
        Console.WriteLine("Value in the called function is : " + val); 
    }

    // call by out function

    public void func5(out int val)
    {
        val = 5;
        val = val + 10; 
    }

    // main function
    public static void Main(string[] args)
    {
        FunctionWithAndWithoutParameterAndCallByValueAndRef obj1 = new FunctionWithAndWithoutParameterAndCallByValueAndRef();
        
        // simple demonstration of the function
        obj1.func(); 
        Console.WriteLine();

        // without parameter function
        obj1.func1();
        Console.WriteLine();

        // with parameter function
        obj1.func2(10, 5);
        Console.WriteLine();

        // with return  function
        int result = obj1.mul(10, 5);
        Console.WriteLine("result is : " + result); 
        Console.WriteLine();


        FunctionWithAndWithoutParameterAndCallByValueAndRef obj2 = new FunctionWithAndWithoutParameterAndCallByValueAndRef();


        // call by value function 
        int val = 15;
        Console.WriteLine("Value before calling the funtion : " + val);
        obj2.func3(val);
        Console.WriteLine("Value after calling the funtion : " + val);
        Console.WriteLine();

        // call by referece function
        Console.WriteLine("Value before calling the funtion : " + val);
        obj2.func4(ref val);
        Console.WriteLine("Value after calling the funtion : " + val);
        Console.WriteLine();

        //call by out function 
        val = 6;
        Console.WriteLine("Value before calling the funtion : " + val);
        obj2.func5(out val);
        Console.WriteLine("Value after calling the funtion : " + val);
        Console.WriteLine();
    }
}

