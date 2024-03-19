using System;

public class Circle : Shape
{
    private double radius;

    public Circle(IColor color, double radius) : base(color)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
