using System;

public class Square : Shape
{
    private double sideLength;

    public Square(IColor color, double sideLength) : base(color)
    {
        this.sideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return sideLength * sideLength;
    }

    public override double CalculatePerimeter()
    {
        return 4 * sideLength;
    }
}
