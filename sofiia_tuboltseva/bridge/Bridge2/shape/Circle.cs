using Bridge2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle : Shape
{
    private double radius;

    public Circle(double radius, IColor color) : base(color)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Circle side must be positive and non-zero.");
        }
        this.radius = radius;
    }

    public override void Draw()
    {
        Console.Write("Circle ");
        color.FillWithColor();
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}