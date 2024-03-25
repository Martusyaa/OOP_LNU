using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Circle : Figure
{
    private double radius;

    public Circle(Color color, double radius) : base(color)
    {
 
        if (radius <= 0)
        {
            throw new ArgumentException("Радіус має бути > 0");
        }

        this.radius = radius;
    }

    public override string Name()
    {
        return "Circle";
    }

    public override double Area()
    {
        //if (radius <= 0)
        //{
        //    throw new ArgumentException("Радіус має бути > 0");
        //}
        //else
        //{
        //    return Math.PI * radius * radius;
        //}

        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        //if (radius <= 0)
        //{
        //    throw new ArgumentException("Радіус має бути > 0");
        //}
        //else
        //{
        //    return 2 * Math.PI * radius;
        //}

        return 2 * Math.PI * radius;
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
    internal class Circle
    {
    }
}
