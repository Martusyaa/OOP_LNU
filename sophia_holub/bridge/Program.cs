using System;
using System.IO;
abstract class Shape
{
    protected IColor color;

    public Shape(IColor color)
    {
        this.color = color;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();
}


class Square : Shape
{
    private double side;

    public Square(double side, IColor color) : base(color)
    {
        this.side = side;
    }

    public override double GetArea()
    {
        return side * side;
    }

    public override double GetPerimeter()
    {
        return 4 * side;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width, IColor color) : base(color)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }

    public override double GetPerimeter()
    {
        return 2 * (length + width);
    }
}

class Triangle : Shape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3, IColor color) : base(color)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double GetArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double GetPerimeter()
    {
        return side1 + side2 + side3;
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius, IColor color) : base(color)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}


interface IColor
{
    void FillColor();
}

class RedColor : IColor
{
    public void FillColor()
    {
        Console.WriteLine("Coloring figure with red color.");
    }
}

class BlueColor : IColor
{
    public void FillColor()
    {
        Console.WriteLine("Coloring figure with blue color.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] colorLines = File.ReadAllLines(@"C:\\Sofia\\prog and crypto\\Bridge\\Bridge\\Bridge\\colors.txt");
        IColor[] colors = new IColor[colorLines.Length];
        for (int i = 0; i < colorLines.Length; i++)
        {
            if (colorLines[i] == "Red")
                colors[i] = new RedColor();
            else if (colorLines[i] == "Blue")
                colors[i] = new BlueColor();
        }

        
        string[] shapeLines = File.ReadAllLines(@"C:\\Sofia\\prog and crypto\\Bridge\\Bridge\\Bridge\\shapes.txt");
        for (int i = 0; i < shapeLines.Length; i++)
        {
            string[] parts = shapeLines[i].Split(',');
            string shapeType = parts[0];
            double[] parameters = new double[parts.Length - 1];
            for (int j = 0; j < parameters.Length; j++)
            {
                parameters[j] = double.Parse(parts[j + 1]);
            }

            IColor color = colors[i];
            Shape shape;
            switch (shapeType)
            {
                case "Square":
                    shape = new Square(parameters[0], color);
                    break;
                case "Rectangle":
                    shape = new Rectangle(parameters[0], parameters[1], color);
                    break;
                case "Triangle":
                    shape = new Triangle(parameters[0], parameters[1], parameters[2], color);
                    break;
                case "Circle":
                    shape = new Circle(parameters[0], color);
                    break;
                default:
                    throw new ArgumentException("Unknown shape type: " + shapeType);
            }

            color.FillColor();
            Console.WriteLine("Area: " + shape.GetArea());
            Console.WriteLine("Perimeter: " + shape.GetPerimeter());
        }
    }
}
