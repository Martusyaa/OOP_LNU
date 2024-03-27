using System;
using FiguresLab.Figure;

namespace FiguresLab.Figure
{
    public class Program
    {
        private static Shape? ReadShapeFromFile(string filename)
        {
            using (StreamReader file = new StreamReader(filename))
            {
                Color color = null;
                Shape figure = null;

                try
                {
                    string? shapeLine = file.ReadLine().Trim();
                    string? colorLine = file.ReadLine().Trim();
                    double[] figureValues = file.ReadLine().Split(",").Select(Double.Parse).ToArray();

                    switch (colorLine)
                    {
                        case "Yellow":
                            color = new Yellow();
                            break;
                        case "Red":
                            color = new Red();
                            break;
                        case "Blue":
                            color = new Blue();
                            break;
                        default:
                            throw new Exception("Bad file format");
                            break;
                    }

                    switch (shapeLine)
                    {
                        case "Triangle":
                            figure = new Triangle(figureValues[0], figureValues[1], figureValues[2], color);
                            break;
                        case "Square":
                            figure = new Square(figureValues[0], color);
                            break;
                        case "Circle":
                            figure = new Circle(figureValues[0], color);
                            break;
                        case "Rectangle":
                            figure = new Rectangle(figureValues[0], figureValues[1], color);
                            break;
                        default:
                            throw new Exception("Bad file format");
                    }

                    return figure;
                }

                catch(Exception ex)
                {
                    Console.WriteLine("Bad File format");
                    return null;
                }
                    
            }
        }

        private static void Main()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            string triangleFilepath  = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Triangle.txt"); 
            string squareFilepath    = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Square.txt"); 
            string circleFilepath    = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Circle.txt");
            string rectangleFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Rectangle.txt");

            if (!File.Exists(triangleFilepath) || !File.Exists(squareFilepath) || 
                !File.Exists(circleFilepath) || !File.Exists(rectangleFilePath))
            {
                throw new FileNotFoundException();
            }

            Triangle? triangleObject = ReadShapeFromFile(triangleFilepath) as Triangle;
            Square? squareObject = ReadShapeFromFile(squareFilepath) as Square;
            Circle? circleObject = ReadShapeFromFile(circleFilepath) as Circle;
            Rectangle? rectangleObject = ReadShapeFromFile(rectangleFilePath) as Rectangle;

            if (triangleObject == null || squareObject == null 
                || circleObject == null || rectangleObject == null)
            {
                throw new Exception("Instance not valid");
            }

            // Triangle Output
            Console.WriteLine($"\nTriangle sides: " +
                $"{triangleObject.FirstSide}, {triangleObject.SecondSide}, {triangleObject.ThirdSide}");
            Console.WriteLine($"Triangle perimiter: {triangleObject.CalculatePerimeter()}");
            Console.WriteLine($"Triangle area: {triangleObject.CalculateArea()}");
            triangleObject.ShowColor();

            // Square output
            Console.WriteLine($"\nSquare side: {squareObject.Side}");
            Console.WriteLine($"Square perimiter: {squareObject.CalculatePerimeter()}");
            Console.WriteLine($"Square area: {squareObject.CalculateArea()}");
            squareObject.ShowColor();

            // Circle output
            Console.WriteLine($"\nCircle radius: {circleObject.Radius}");
            Console.WriteLine($"Circle perimiter: {circleObject.CalculatePerimeter()}");
            Console.WriteLine($"Circle area: {circleObject.CalculateArea()}");
            circleObject.ShowColor();

            // Rectangle output
            Console.WriteLine($"\nRectangle radius: {rectangleObject.FirstSide}, {rectangleObject.SecondSide}");
            Console.WriteLine($"Rectangle perimiter: {rectangleObject.CalculatePerimeter()}");
            Console.WriteLine($"Rectangle area: {rectangleObject.CalculateArea()}");
            rectangleObject.ShowColor();

        }

    }
}
