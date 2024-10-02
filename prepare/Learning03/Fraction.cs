using System;
public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        //Initializes the fraction to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        //Initializes the fraction to {top}/1.
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        //Initializes the fraction to {top}/{bottom}.
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        //Returns the fraction in the form 3/4.
        string form = $"{_top}/{_bottom}";
        return form;
    }

    public double GetDecimalValue()
    {
        //Returns a double that is the result of dividing the top number by the bottom number.
        return (double)_top / (double)_bottom;
    }


}