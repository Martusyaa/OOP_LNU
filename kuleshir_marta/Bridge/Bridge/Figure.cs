namespace Bridge;

public abstract class Figure
{
    protected IColor color;

    public Figure(IColor color)
    {
        this.color = color;
        ValidateColor();
    }

    protected abstract void ValidateColor();

    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();
}