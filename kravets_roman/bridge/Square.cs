using System;

namespace Shapes
{
    class Square : Shape
    {
        private double side;

        public Square(double side, IColor color) : base(color)
        {
            this.side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {color.Fill()} square with side {side}");
        }

        public override double CalculateArea()
        {
            return side * side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * side;
        }
    }
}
