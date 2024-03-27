using System;

namespace Shapes
{
    static void Main(string[] args)
    {
        Shape square = new Square(5, new RedColor());
        square.Draw();
        Console.WriteLine($"Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");
        Shape circle = new Circle(3, new GreenColor());
        circle.Draw();
        Console.WriteLine($"Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");

    }
}
