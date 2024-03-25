using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Circle whiteCircle = new Circle(new FirstColor(), 5);
        whiteCircle.Print();

        Rectangle blueRectangle = new Rectangle(new SecondColor(), 4, 6);
        blueRectangle.Print();

        Square purpleSquare = new Square(new ThirdColor(), 3);
        purpleSquare.Print();

        Triangle blueTriangle = new Triangle(new SecondColor(), 5, 12, 13);
        blueTriangle.Print();
    }
}
