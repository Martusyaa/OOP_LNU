using Bridge2;

class Program
{
    static void Main()
    {
        try
        {
            IColor red = new RedColor();
            IColor blue = new BlueColor();
            IColor yellow = new YellowColor();

            Shape circle = new Circle(-2, red);
            circle.Draw();
            Console.WriteLine($", Area: {circle.GetArea()}, Perimeter: {circle.GetPerimeter()}");

            Shape square = new Square(2, blue);
            square.Draw();
            Console.WriteLine($", Area: {square.GetArea()}, Perimeter: {square.GetPerimeter()}");

            Shape rectangle = new Rectangle(6, 4, yellow);
            rectangle.Draw();
            Console.WriteLine($", Area: {rectangle.GetArea()}, Perimeter: {rectangle.GetPerimeter()}");

            Shape triangle = new Triangle(6, 4, 7, yellow);
            rectangle.Draw();
            Console.WriteLine($", Area: {triangle.GetArea()}, Perimeter: {triangle.GetPerimeter()}");

        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
