namespace Bridge
{
    public class Triangle : Figure
    {
        private double sideA;
        private double sideB;


        public Triangle(Color color, double given_side, double _sideA, double _sideB) : base(color, given_side)
        {
            sideA = _sideA;
            sideB = _sideB;
        }

        public override double Perimeter()
        {
            if (given_side <= 0 || sideA <= 0 || sideB <= 0 )
            {
                throw new ArgumentException("Side cannot be equal 0 or be less than 1!");
            }
            else
            {
                return given_side + sideA + sideB;
            }
        }

        public override double Area()
        {
            if (given_side <= 0 || sideA <= 0 || sideB <= 0)
            {
                throw new ArgumentException("Side cannot be equal 0 or be less than 1!");
            }
            else
            {
                var p = (given_side + sideA + sideB) / 2;
                return Math.Sqrt(p * (p- given_side) * (p - sideA) * (p - sideB));
            }
        }
    }
}
