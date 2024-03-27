using Bridge;

class Program
{
    static void Main()
    {
        Console.WriteLine("Circle:");
        try
        {
            Circle circle = new Circle(new Blue(), 3);
            circle.Print();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("Rectangle:");
        try
        {
            Rectangle rectangle = new Rectangle(new Yellow(), 2, 5);
            rectangle.Print();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("Square:");
        try
        {
            Square square = new Square(new Green(), 2);
            square.Print();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("Triangle:");
        try
        {  
            Triangle triangle = new Triangle(new Pink(), 2, 3, 4);
            triangle.Print();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}