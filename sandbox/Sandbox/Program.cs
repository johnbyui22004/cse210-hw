using System;


class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(10);
        myCircle.DisplayCircleArea();
        Cylinder myCylinder = new Cylinder(10, myCircle);
        double volume = myCylinder.GetVolume();
        Console.WriteLine($"The cylinder volume is: {volume}");





        // // double x=10;
        // Circle myCircle=new Circle(10);

        // Console.WriteLine($"The area of the circle is: {myCircle.GetArea()}");

    }
    

    
}
