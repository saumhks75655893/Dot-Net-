using System;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overload the + operator
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X+b.X,a.Y + b.Y); 
        //return new Point(a.X + b.X, a.Y + b.Y);
    }

    // Overload the - operator
    public static Point operator -(Point a, Point b)
    {
        return new Point(a.X - b.X, a.Y - b.Y);
    }

    // Override ToString for pretty printing
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(2, 3);
        Point p2 = new Point(4, 5);

        Point sum = p1 + p2;
        Point diff = p2 - p1;

        Console.WriteLine($"Point 1: {p1}");
        Console.WriteLine($"Point 2: {p2}");
        Console.WriteLine($"Sum:     {sum}");
        Console.WriteLine($"Diff:    {diff}");
    }
}
