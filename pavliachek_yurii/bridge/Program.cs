using System;

namespace Bridge
{
    class Program
    {
        static void Main()
        {
            Color orange = new Orange();
            Color blue = new Blue();
            Color red = new Red();
            Color yellow = new Yellow();

            Shape rectangle = new Rectangle(3, 4, orange);
            Shape square = new Square(5, blue);
            Shape circle = new Circle(4, red);
            Shape triangle = new Triangle(2, 4, 3, yellow);
            
            Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter()}, Rectangle Area: {rectangle.Area()}, Rectangle Color: {rectangle.GetColor()};");
            Console.WriteLine($"Square Perimeter: {square.Perimeter()}, Square Area: {square.Area()}, Square Color: {square.GetColor()};");
            Console.WriteLine($"Circle Perimeter: {circle.Perimeter()}, Cicrle Area: {circle.Area()}, Cicrle Color: {circle.GetColor()};");
            Console.WriteLine($"Triangle Perimeter: {triangle.Perimeter()}, Triangle Area: {triangle.Area()}, Triangle Color: {triangle.GetColor()}");


        }
    }
}
