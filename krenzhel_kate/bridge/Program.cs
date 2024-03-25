class Program
{
    static void Main(string[] args)
    {
        try
        {
            Figure redCircle = new Circle(new Red(), 5);
            redCircle.Print();

            Figure blueRectangle = new Rectangle(new Blue(), 4, 6);
            blueRectangle.Print();

            Figure blueSquare = new Square(new Blue(), 3);
            blueSquare.Print();

            Figure redTriangle = new Triangle(new Red(), 3, 4, 5);
            redTriangle.Print();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}