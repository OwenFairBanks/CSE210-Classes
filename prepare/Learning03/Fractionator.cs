public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string Make_Fraction()
    {
        return $"{_top}/{_bottom}";
    }
    public double Compute_Fraction()
    {
        return  (double)_top / (double)_bottom ;
    }
}