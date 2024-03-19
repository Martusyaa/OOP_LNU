using System;

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(IColor color, double width, double height) : base(color)
    {
        this.width = width;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return width * height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}
