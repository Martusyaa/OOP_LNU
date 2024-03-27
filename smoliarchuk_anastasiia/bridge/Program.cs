using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating shapes with colors:");

            
            Shape square = new Square(new Red());
            square.Draw();
            square.CalculateArea();
            square.CalculatePerimeter();

            Shape rectangle = new Rectangle(new Blue());
            rectangle.Draw();
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();

            Shape triangle = new Triangle(new Green());
            triangle.Draw();
            triangle.CalculateArea();
            triangle.CalculatePerimeter();

            Shape circle = new Circle(new Yellow());
            circle.Draw();
            circle.CalculateArea();
            circle.CalculatePerimeter();
        }
    }
}

