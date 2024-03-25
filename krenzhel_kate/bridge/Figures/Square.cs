using System;

public class Square : Figure
{

    public Square(Color color, double side) : base(color, side){}

    public override double CalculatePerimeter()
    {
        return 4 * side;
    }

    public override string Name()
    {
        return "Square";
    }

    public override double CalculateArea()
    {
        return side * side;
    }
}