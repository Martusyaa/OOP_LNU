using System;

public class Circle : Figure
{

    public Circle(Color color, double side) : base(color, side) {}

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * side;
    }

    public override string Name()
    {
        return "Circle";
    }

    public override double CalculateArea()
    {
        return Math.PI * side * side;
    }
}