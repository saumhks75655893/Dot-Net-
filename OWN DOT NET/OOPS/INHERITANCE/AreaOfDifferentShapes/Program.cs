using System;


class shapes
{
    internal double pi = 3.14; 
    internal double width; 
    internal double height;
    internal double radius; 

    public shapes()
    {
        //; 
    }

    // width one argument 
    public shapes(double r)
    {
        this.radius = r;
        double area = pi * radius * radius;
        Console.WriteLine("The are of the circle is : " + area);  
    }

    // widht two arguments
    public shapes(double w, double h)
    {
        this.width = w;
        this.height = h;
        double area = w * h;
        Console.WriteLine("The area of the ractangle is : " + area); 
    }

    //with three arguments
    public shapes(double half,  double width, double height)
    {
        this.width = width; 
        this.height = height;

        double area = half * width * height;
        Console.WriteLine("The area of the triangle is : " + area); 
    }

}

//single level inheritance
class AreaOfCircle : shapes
{
    public void CircleArea(double r)
    {
        radius = r;
        double area = pi * radius * radius;
        Console.WriteLine("The area of the circle is : " + area);
    }
}
class Program
{
    static void Main(string[] args)
    {
        AreaOfCircle area = new AreaOfCircle();
        area.CircleArea(12.3);

        //circle
        shapes s = new shapes(12.3);
        shapes s1 = new shapes(10.2, 12.3);
        shapes s2 = new shapes(0.5, 10, 20); 

    }
}

