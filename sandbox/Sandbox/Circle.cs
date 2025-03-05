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
    public void DisplayCircleArea()
    {
        Console.WriteLine($"this is the area of your circle: {GetArea()}");
    }
}