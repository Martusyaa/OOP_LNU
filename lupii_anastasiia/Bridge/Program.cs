using System;
using System.Collections.Generic;
using Bridge;
internal class Program
{
    private static void Main(string[] args)
    {
        var figures = new List<Figure>
            {
                new Circle(new Red{},4), 
                new Rectangle( new Brown{}, 4,5),
                new Square(new Blue{},6),
                new Triangle(new Green{},3, 4, 5)
            };

       foreach (var figure in figures)
        {
            Console.WriteLine($"{figure.GetType().Name} - Color: {figure.Color.PaintColor()}, Perimeter: {figure.Perimeter():F2}, Area: {figure.Area():F2}");
        }

    }
}