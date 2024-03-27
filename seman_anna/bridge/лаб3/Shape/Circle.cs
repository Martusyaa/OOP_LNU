using System;

public class Circle : Shape
{
    protected double radius;

    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    public override string Draw()
    {
        return $"Draw a {color} circle";
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