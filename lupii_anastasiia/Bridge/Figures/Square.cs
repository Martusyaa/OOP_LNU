using System;

namespace Bridge
{
    public class Square : Figure
    {
        private  double side;

        public Square(Color color, double side) : base(color)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side of the square cannot be 0 or negative.", nameof(side));
            }
            this.side = side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }

        public override double Area()
        {
            return side * side;
        }
    }
}
