namespace Bridge
{
    public class Rectangle : Figure
    {
        private double length;
        private double width;

        public Rectangle(Color color, double given_side, double _width) : base(color, given_side)
        {
            length = given_side;
            width = _width;
        }

        public override double Perimeter()
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Invalid rectangle sides!");
            }
            else
            {
                return 2 * (length + width);
            }
        }

        public override double Area()
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Side cannot be equal 0 or be less than 1!");
            }
            else
            {
                return length * width;
            }
        }
    }
}
