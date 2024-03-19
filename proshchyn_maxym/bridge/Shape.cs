using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgePattern
{

    public abstract class Shape
    {
        protected int length = 0;
        protected int width = 0;
        protected int radius = 0;

        protected Color color;

        
        public Shape(Color color)
        {
            this.color = color;
        }
        
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();

        public string Draw()
        {
            return $"{GetType().Name} with {color.FillColor()} color";
        }
    }


    public class Rectangle : Shape
    {
        public Rectangle(int length, int width, Color color) : base(color)
        {
            if (length <= 0 || width <= 0)
                throw new ArgumentException("Length and width should be positive values.");

            this.length = length;
            this.width = width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        public override double CalculateArea()
        {
            return length * width;
        }
    }

    public class Square : Rectangle
    {
        public Square(int side, Color color) : base(side, side, color) { }
    }

    public class Triangle : Shape
    {
        public Triangle(int length, int width, int radius, Color color) : base(color) 
        {
            if (length <= 0 || width <= 0 || radius <= 0)
                throw new ArgumentException("Length, width, and radius should be positive values.");

            this.length = length;
            this.width = width;
            this.radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return length + width + radius;
        }

        public override double CalculateArea()
        {
            double s = (length + width + radius) / 2.0;
            return Math.Sqrt(s * (s - length) * (s - width) * (s - radius));
        }
    }

    public class Circle : Shape
    {
        public Circle(int radius ,Color color) : base(color) 
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be a positive value.");

            this.radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}