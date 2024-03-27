using System;
using System.Drawing;

namespace BridgePattern
{
   
    public abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void Draw();
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }

    
    public class Square : Shape
    {
        public Square(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Square in {color.Paint()}");
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Calculating area of Square");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine("Calculating perimeter of Square");
        }
    }

    
    public class Rectangle : Shape
    {
        public Rectangle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Rectangle in {color.Paint()}");
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Calculating area of Rectangle");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine("Calculating perimeter of Rectangle");
        }
    }

    
    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Triangle in {color.Paint()}");
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Calculating area of Triangle");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine("Calculating perimeter of Triangle");
        }
    }

   
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle in {color.Paint()}");
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Calculating area of Circle");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine("Calculating perimeter of Circle");
        }
    }
}
