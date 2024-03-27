using Bridge2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width, IColor color) : base(color)
    {
        if (length <= 0 || width <= 0)
        {
            throw new ArgumentException("Rectangle sides must be positive and non-zero.");
        }
        this.length = length;
        this.width = width;
    }

    public override void Draw()
    {
        Console.Write("Rectangle ");
        color.FillWithColor();
    }

    public override double GetArea()
    {
        return length * width;
    }

    public override double GetPerimeter()
    {
        return 2 * (length + width);
    }
}
