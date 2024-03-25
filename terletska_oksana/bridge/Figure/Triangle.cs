using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Triangle : Figure
{
    protected double sideA;
    protected double sideB;
    private double sideC;

    public Triangle(Color color, double sideA, double sideB, double sideC) : base(color)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Сторони мають бути > 0");
        }

        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public override string Name()
    {
        return "Triangle";
    }

    public override double Area()
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

        //if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        //{
        //    throw new ArgumentException("Сторони мають бути > 0");
        //}
        //else
        //{
        //    double p = (sideA + sideB + sideC) / 2;
        //    return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        //}
    }

    public override double Perimeter()
    {
        return sideA + sideB + sideC;

        //if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        //{
        //    throw new ArgumentException("Сторони мають бути > 0");
        //}
        //else
        //{
        //    return sideA + sideB + sideC;
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
    internal class Triangle
    {
    }
}
