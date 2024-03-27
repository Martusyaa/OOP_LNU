namespace Bridge;

public class Rectangle : Figure
{
    private double width;
    private double height;

    public Rectangle(IColor color, double width, double height) : base(color)
    {
        this.width = width;
        this.height = height;
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
        return width * height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}