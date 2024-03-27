using System;
public class Triangle : Shape
{
    protected double side;

    public Triangle(string color, double side) : base(color)
    {
        this.side = side;
    }

    public override string Draw()
    {
        return $"Draw a {color} triangle";
    }

    public override double CalculateArea()
    {
        double semiPerimeter = CalculatePerimeter() / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - side) * (semiPerimeter - side) * (semiPerimeter - side));
    }

    public override double CalculatePerimeter()
    {
        return 3 * side;
    }
}