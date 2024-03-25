using Bridge2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle : Shape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3, IColor color) : base(color)
    {
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            throw new ArgumentException("Triangle sides must be positive and non-zero.");
        }
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override void Draw()
    {
        Console.Write("Triangle ");
        color.FillWithColor();
    }

    public override double GetArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double GetPerimeter()
    {
        return side1 + side2 + side3;
    }
}
