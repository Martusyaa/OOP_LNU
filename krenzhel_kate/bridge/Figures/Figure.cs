public abstract class Figure
{
    protected Color color;
    protected double side;

    public Figure(Color color, double side)
    {
        this.color = color;
        if (side <= 0)
            throw new ArgumentException("Side must be more than 0.");
        this.side = side;
    }

    public abstract double CalculatePerimeter();

    public abstract string Name();

    public abstract double CalculateArea();

    public void Print()
    {
        Console.WriteLine("Name: " + Name());
        Console.WriteLine("Perimeter: " + CalculatePerimeter());
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Color: " + color.ApplyColor());
        Console.WriteLine();
    }
}