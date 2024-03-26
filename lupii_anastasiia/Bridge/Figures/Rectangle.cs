using System;

namespace Bridge
{
    public class Rectangle : Figure
    {
        private double length;
        private double width;
      
        public Rectangle(Color color, double length, double width) : base(color)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Length and width of the rectangle cannot be 0 or negative.");
            }
            this.length = length;
            this.width = width;
        }

        

        public override double Perimeter()
        {
            return 2 * (length + width);
        }

        public override double Area()
        {
            return length * width;
        }
    }
}
