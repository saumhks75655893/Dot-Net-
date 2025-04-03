using System;

class destructorExample
{
    public destructorExample()
    {
        Console.WriteLine("Constructor Called !!!"); 
    }

    ~destructorExample()
    {
        Console.WriteLine("Destructor Called to clean up unmanaged objects !!!"); 
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        destructorExample dse = new destructorExample();
    }
}

