using System;

namespace Bridge
{
    public class Triangle : Figure
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(Color color, double sideA, double sideB, double sideC) : base(color)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides of the triangle cannot be 0 or negative.");
            }
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("The sum of any two sides of a triangle must be greater than the third side.");
            }
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
    }
}
