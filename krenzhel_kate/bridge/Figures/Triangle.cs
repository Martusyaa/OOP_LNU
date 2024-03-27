using System;

public class Triangle : Figure
{
    private double secondSide;
    private double thirdSide;

    public Triangle(Color color, double side, double secondSide, double thirdSide) : base(color, side)
    {
        if (secondSide <= 0 || thirdSide <= 0)
            throw new ArgumentException("Sides must be more than 0.");
        
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public override double CalculatePerimeter()
    {
        return side + secondSide + thirdSide;
    }

    public override string Name()
    {
        return "Triangle";
    }

    public override double CalculateArea()
    {
        double s = CalculatePerimeter() / 2;
        return Math.Sqrt(s * (s - side) * (s - secondSide) * (s - thirdSide));
    }
}