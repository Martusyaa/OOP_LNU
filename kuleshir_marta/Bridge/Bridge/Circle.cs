namespace Bridge;

public class Circle : Figure
{
    private double radius;

    public Circle(IColor color, double radius) : base(color)
    {
        this.radius = radius;
    }

    protected override void ValidateColor()
    {
        if (color.ApplyColor() != "Red" && color.ApplyColor() != "Green" && color.ApplyColor() != "Blue")
        {
            throw new ArgumentException("Недопустимий колір");
        }
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}