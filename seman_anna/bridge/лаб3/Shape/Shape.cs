using System;

public abstract class Shape
{
    protected string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public abstract string Draw();

    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();
}