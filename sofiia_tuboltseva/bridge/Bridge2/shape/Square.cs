using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Square : Rectangle
{
    
    private double side;


    public Square(double side, IColor color) : base(side, side, color)
    {
        if (side <= 0)
        {
            throw new ArgumentException("Square side must be positive and non-zero.");
        }
        this.side = side;
    }

    public override void Draw()
    {
        Console.Write("Square ");
        color.FillWithColor();
    }

    public override double GetArea()
    {
        return side * side;
    }

    public override double GetPerimeter()
    {
        return 4 * side;
    }
}