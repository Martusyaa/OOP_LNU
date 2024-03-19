public abstract class Shape
{
    public IColor color;

    public Shape(IColor color)
    {
        this.color = color;
    }

    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}
