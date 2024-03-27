using System;
using System.Drawing;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Shape rectangle = new Rectangle(5, 3, new Red());
                Console.WriteLine("Rectangle |\tPerimeter: " + rectangle.CalculatePerimeter()
                                + "\tArea: " + rectangle.CalculateArea() + "\n" + rectangle.Draw() + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error creating Red Rectangle: " + ex.Message);
            }

            try
            {
                Shape circle = new Circle(4, new Blue());
                Console.WriteLine("Circle |\tPerimeter: " + circle.CalculatePerimeter()
                                + "\tArea: " + circle.CalculateArea() + "\n" + circle.Draw() + "\n");               
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error creating Blue Circle: " + ex.Message);
            }

            try
            {
                Shape triangle = new Triangle(6, 7, 8, new Green());
                Console.WriteLine("Triangle |\tPerimeter: " + triangle.CalculatePerimeter()
                                + "\tArea: " + triangle.CalculateArea() + "\n" + triangle.Draw() + "\n");               
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error creating Green Triangle: " + ex.Message);
            }

            try
            {
                Shape square = new Square(-1, new Blue());
                Console.WriteLine("Square |\tPerimeter: " + square.CalculatePerimeter()
                                + "\tArea: " + square.CalculateArea() + "\n" + square.Draw() + "\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error creating Red Square: " + ex.Message);
            }

        }
    }
}