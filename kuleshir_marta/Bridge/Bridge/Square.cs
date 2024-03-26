using System;

namespace Bridge
{
    public class Square : Rectangle
    {
        private double sideLength;

        public Square(IColor color, double sideLength) : base(color, sideLength, sideLength)
        {
            this.sideLength = sideLength;
        }

        protected override void ValidateColor()
        {
            if (color.ApplyColor() != "Red" && color.ApplyColor() != "Green")
            {
                throw new ArgumentException("Недопустимий колір");
            }
        }

        public override double CalculateArea()
        {
            return Math.Pow(sideLength, 2);
        }

        public override double CalculatePerimeter()
        {
            return 4 * sideLength;
        }
    }
}