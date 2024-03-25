using System;

namespace Bridge
{
    public abstract class Figure
    {
        protected Color color;
        protected double given_side;

        public Figure(Color _color, double _side)
        {
            color = _color;
            given_side = _side;
        }

        public abstract double Perimeter();

        public abstract double Area();

        public void Print()
        {
            Console.WriteLine("Perimeter: " + Perimeter());
            Console.WriteLine("Area: " + Area());
            Console.WriteLine("Color: " + color.Painting());
            Console.WriteLine("------------");
        }
    }
}