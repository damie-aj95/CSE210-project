public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;
    
    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    
    // Getters
    public int GetTop()
    {
        return _top;
    }
    
    public int GetBottom()
    {
        return _bottom;
    }
    
    // Setters
    public void SetTop(int top)
    {
        _top = top;
    }
    
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    
    // Return fraction as a string like "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    
    // Return decimal value like 0.75
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}