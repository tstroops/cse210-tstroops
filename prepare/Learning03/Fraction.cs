class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        SetNumerator(1);
        SetDenominator(1);
    }
    

    public Fraction(int top)
    {
        SetNumerator(top);
        SetDenominator(1);
    }
    public Fraction(int top, int bottom)
    {
        SetNumerator(top);
        SetDenominator(bottom);
    }

    public void SetNumerator(int top)
    {
        _numerator = top;
    }

    public void SetDenominator(int bottom)
    {
        if (bottom != 0)
        {
            _denominator = bottom;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public float GetDecimalValue()
    {
        float n = _numerator;
        float d = _denominator;
        return n / d;
    }
}