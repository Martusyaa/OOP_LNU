using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle : Figure
{
    protected double sideA;
    protected double sideB;

    public Rectangle(Color color, double sideA, double sideB) : base(color)
    {
        if (sideA <= 0 || sideB <= 0)
        {
            throw new ArgumentException("Сторони мають бути > 0");
        }

        this.sideA = sideA;
        this.sideB = sideB;
    }

    public override string Name()
    {
        return "Rectangle";
    }

    public override double Area()
    {
        return sideA * sideB;

        //if (sideA <= 0 || sideB <= 0)
        //{
        //    throw new ArgumentException("Сторони мають бути > 0");
        //}
        //else
        //{
        //    return sideA * sideB;
        //}
    }

    public override double Perimeter()
    {
        return 2 * (sideA + sideB);

        //if (sideA <= 0 || sideB <= 0)
        //{
        //    throw new ArgumentException("Сторони мають бути > 0");
        //}
        //else
        //{
        //    return 2 * (sideA + sideB);
        //}
    }

    public void Print()
    {
        Console.WriteLine("\nName: "+ Name());
        Console.WriteLine("Perimeter: "+ Perimeter());
        Console.WriteLine("Area: "+ Area());
        Console.WriteLine("Color: "+ color.Draw());
    }
}

   


namespace Bridge.Figure
{
    internal class Rectangle
    {
    }
}
