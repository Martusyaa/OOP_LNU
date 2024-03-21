using System;
public class Rectangle : Shape
{
    protected double width;
    protected double height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        this.width = width;
        this.height = height;
    }

    public override string Draw()
    {
        return $"Draw a {color} rectangle";
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
