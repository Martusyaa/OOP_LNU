using System;
using System.Globalization;
using System.IO;

class Program
{
    static void Main()
    {
        string[] filenames = { "Circle.txt", "Rectangle.txt", "Triangle.txt", "Square.txt" };

        foreach (var filename in filenames)
        {
            Shape shape = ReadShapeFromFile(filename);
            if (shape != null)
            {
                Console.WriteLine($"Figure from file {filename}:");
                Console.WriteLine($"Color: {shape.color.FillColor()}");
                Console.WriteLine($"Area: {shape.CalculateArea()}");
                Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}\n");
            }
        }
    }

    static Shape ReadShapeFromFile(string filename)
{
    string[] lines = File.ReadAllLines(filename);
    if (lines.Length == 0)
    {
        Console.WriteLine($"File {filename} is empty.");
        return null;
    }

    string[] data = lines[0].Split(); // Розділити перший рядок на окремі слова
    string figureType = data[0]; // Перше слово - тип фігури
    string color = data[data.Length - 1]; // Останнє слово - колір фігури

    switch (figureType)
    {
        case "Circle":
            if (data.Length < 3)
            {
                Console.WriteLine($"Insufficient data for Circle in file {filename}.");
                return null;
            }
            double radius = double.Parse(data[1]);
            return new Circle(GetColor(color), radius);

        case "Rectangle":
            if (data.Length < 4)
            {
                Console.WriteLine($"Insufficient data for Rectangle in file {filename}.");
                return null;
            }
            double width = double.Parse(data[1]);
            double height = double.Parse(data[2]);
            return new Rectangle(GetColor(color), width, height);

        case "Triangle":
            if (data.Length < 5)
            {
                Console.WriteLine($"Insufficient data for Triangle in file {filename}.");
                return null;
            }
            double side1 = double.Parse(data[1]);
            double side2 = double.Parse(data[2]);
            double side3 = double.Parse(data[3]);
            return new Triangle(GetColor(color), side1, side2, side3);

        case "Square":
            if (data.Length < 3)
            {
                Console.WriteLine($"Insufficient data for Square in file {filename}.");
                return null;
            }
            double sideLength = double.Parse(data[1]);
            return new Square(GetColor(color), sideLength);

        default:
            Console.WriteLine($"Unknown figure type '{figureType}' in file {filename}.");
            return null;
    }
}

static IColor GetColor(string color)
{
    switch (color.ToLower())
    {
        case "red":
            return new RedColor();
        case "blue":
            return new BlueColor();
        case "yellow":
            return new YellowColor();
        case"green":
            return new GreenColor();
        default:
            Console.WriteLine($"Unknown color '{color}'. Using default color.");
            return new RedColor(); 
    }
}

}
