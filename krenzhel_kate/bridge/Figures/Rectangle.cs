public class Rectangle : Figure
{
    private double secondSide;

    public Rectangle(Color color, double side, double secondSide) : base(color, side)
    {
        if (secondSide <= 0)
            throw new ArgumentException("Sides must be more than 0.");
        this.secondSide = secondSide;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (side + secondSide);
    }

    public override string Name()
    {
        return "Rectangle";
    }

    public override double CalculateArea()
    {
        return side * secondSide;
    }
}