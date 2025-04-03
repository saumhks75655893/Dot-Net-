using System;


//parent class
class parent
{
    internal int a;
    internal int b;
    internal int c; 
}

//child class 1
class child1 : parent
{
    public void sumOfTheVaribales(int a, int b, int c)
    {
        this.a = a; this.b = b; this.c = c;
        int sum = a + b + c;
        Console.WriteLine($"The sum of the {a}, {b}, {c} is : "+ sum);
    }
}

//child class 2
class child2 : parent
{
    public void mulOftheVariables(int a, int b, int c)
    {
        this.a = a; this.b = b; this.c = c; 
        int mul = a * b * c;
        Console.WriteLine($"The multiplication of {a}, {b}, {c} is ; " + mul);
    }
}
class Program
{
    static void Main(string[] args)
    {
        child1 c1 = new child1();
        c1.sumOfTheVaribales(10,20,30);
        

        child2 c2 = new child2();
        c2.mulOftheVariables(10,20,30);
    }
}

