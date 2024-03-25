using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Square : Rectangle
{
    public Square(Color color, double side) : base(color, side, side)
    {
        if (sideA <= 0)
        {
            throw new ArgumentException("Сторона має бути > 0");
        }
    }

    public override string Name()
    {
        return "Square";
    }

    public override double Area()
    {
        return sideA * sideA;

        //if (sideA <= 0)
        //{
        //    throw new ArgumentException("Сторона має бути > 0");
        //}
        //else
        //{
        //    return sideA * sideA;
        //}
    }

    public override double Perimeter()
    {
        return 4 * sideA;

        //if (sideA <= 0)
        //{
        //    throw new ArgumentException("Сторона має бути > 0");
        //}
        //else
        //{
        //    return 4 * sideA;
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
    internal class Square
    {
    }
}
