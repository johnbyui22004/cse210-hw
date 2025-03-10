class Fraction
{
  
    public int Top { get; set; }
    public int Bottom 
    { 
        get { return _Bottom; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _Bottom = value;
        }
    }

    private int _Bottom;

    
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
