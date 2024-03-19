using System;
public class InvalidTriangleException : Exception
{
    public InvalidTriangleException(string message) : base(message)
    {
    }
}
public class Triangle : Shape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(IColor color, double side1, double side2, double side3) : base(color)
    {
        if (!IsValidTriangle(side1, side2, side3))
        {
            throw new ArgumentException("Invalid triangle sides");
        }

        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double CalculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        // Умова трикутника: сума будь-яких двох сторін має бути більшою за третю сторону
        return a + b > c && a + c > b && b + c > a;
    }
}
