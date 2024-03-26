using System;


namespace Bridge
{
    public abstract class Figure
{
    protected Color color;

    protected Figure(Color color)
    {
        this.color = color;
    }

    public abstract double Area();

    public abstract double Perimeter();

    public Color Color => color; 

   
}
}