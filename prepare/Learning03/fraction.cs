public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }
    
    public void SetTopNumber(int number)
    {
        _topNumber = number;
    }

    public int GetBottomNumber()
    {
        return _topNumber;
    }
    
    public void SetBottomNumber(int number)
    {
        _topNumber = number;
    }

    public string GetFractionString()
    {
        string fractionNumber = $"{_topNumber}/{_bottomNumber}";
        return fractionNumber;
    }

    public double GetDecimalValue()
    {
        double decimalValue = _topNumber / (double)_bottomNumber;
        return decimalValue;
    }
}