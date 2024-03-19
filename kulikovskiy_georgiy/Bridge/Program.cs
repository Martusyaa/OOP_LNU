// See https://aka.ms/new-console-template for more information
namespace Bridge
{
  class Program
  {
    static void Main(string[] args)
    {
      IColor red = new Red();
      IColor blue = new Blue();
      Rectangle rectangleOne = new Rectangle(10, 5, red);
      Square squareOne = new Square(5, blue);
      Circle circleOne = new Circle(5, red);
      Triangle triangleOne = new Triangle(5, 10, 15, blue);

      System.Console.WriteLine(rectangleOne.ToString());
      System.Console.WriteLine(squareOne.ToString());
      System.Console.WriteLine(circleOne.ToString());
      System.Console.WriteLine(triangleOne.ToString());
    }
  }
}
