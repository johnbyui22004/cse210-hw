

class Cylinder
{
    private double hight;
    private Circle circle;

    public Cylinder(double hight, Circle circle)
    {
        this.hight = hight;
        this.circle = circle;

    }
    public double GetVolume()
    {
        double volume = hight * circle.GetArea();
        return volume;
    }




}