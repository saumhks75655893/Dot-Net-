using System;



//base class for base2
class base1
{
    internal int a; 
    public base1()
    {
        Console.WriteLine("This is base1");
        a = 10; 
    }
    ~base1()
    {
        Console.WriteLine("DESTRUCTOR FOR CLASS 1"); 
    }
}


//base class for base3 and derived class for base1
class base2: base1
{
    internal int b;
    public base2()
    {
        Console.WriteLine("this is base2");
        b = 20; 
    }
    ~base2()
    {
        Console.WriteLine("DESTRUCTOR FOR CLASS 2");
    }
}

//derived class for base2
class base3 : base2
{
    int c, sum; 

    public base3()
    {
        Console.WriteLine("This is base3");
        c = 30; 
        sum = a + b + c;
        Console.WriteLine($"The sum of the {a} , {b}, {c} is : " + sum); 
    }
    ~base3()
    {
        Console.WriteLine("DESTRUCTOR FOR  CLASS 3");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        base3 b3 = new base3(); 
    }
}

