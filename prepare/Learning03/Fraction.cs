class Fraction
{
  
    private int Top { get; set; }
    private int Bottom { get; set; }

    
    public Fraction()
    {
        Top = 1;
        Bottom = 1;
    }
    public Fraction(int top)
    {
        Top = top;
        Bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        Top = top;
        Bottom = bottom;
    }

    
    public string GetFractionString()
    {
        return $"{Top}/{Bottom}";
    }

  
    public double GetDecimalValue()
    {
        return (double)Top / Bottom;
    }

    
    public void Display()
    {
        Console.WriteLine($"{Top}/{Bottom}");
    }
}
