public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction() : this(1, 1) { } 

    public Fraction(int numerator) : this(numerator, 1) { } 

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set { _denominator = value != 0 ? value : 1; } 
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
