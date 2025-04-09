using System;
using System.Security.Cryptography;

class Space
{
    public int x;
    public int y;
    public int z;


    public void Display()
    {
        Console.WriteLine("x =  " + x + "\ny =  " + y + "\nz =  " + z);
    }

    public static Space operator -(Space a, Space b)
    {
        Space c = new Space();
        c.x = a.x - b.x;
        c.y = a.y - b.y;
        c.z = a.z - b.z;

        return c; 
    }
}
class Program
{
    static void Main(string[] args)
    {
        Space s = new Space();
        s.x = 10;
        s.y = 20;
        s.z = 30;
        Console.WriteLine("Values of the s : ");
        s.Display(); 
        Space s1 = new Space();
        s1.x = 1;
        s1.y = 2;
        s1.z = 3;
        Console.WriteLine("values of s1 : ");
        s1.Display();


        Space space = new Space();
        space = s - s1;
        Console.WriteLine(); 
        Console.WriteLine("Answer for s - s1 is : \n" + "x = "+ space.x+" " + "\ny = " +  space.y + " " + "\nz = " +  space.z);

    }
}

