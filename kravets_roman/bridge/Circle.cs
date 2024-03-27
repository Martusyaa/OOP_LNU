using System;

namespace Shapes
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius, IColor color) : base(color)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.Fill()} circle with radius {radius}");
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
