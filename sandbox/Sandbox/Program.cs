using System;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        double area = Math.PI * radius * radius;
        return area;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // double x=10;
        Circle myCircle=new Circle(10);

        Console.WriteLine($"The area of the circle is: {myCircle.GetArea()}");

    }
    

    
}
