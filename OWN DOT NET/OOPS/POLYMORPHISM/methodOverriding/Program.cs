using System;


class base1
{
    public virtual void Display()
    {
        Console.WriteLine("Parent Class Display Method"); 
    }
}

class child : base1
{
    public override void Display()
    {
        Console.WriteLine("Child Class Display Method"); 
    }
}
class Program
{
static void Main(string[] args)
    {
        base1 obj1 = new child();
        obj1.Display(); 
    }
}
