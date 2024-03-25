namespace Bridge
{
    public class Circle : Figure
    {

        public Circle(Color color, double given_side) : base(color, given_side)
        {
        }

        public override double Perimeter()
        {
            if (given_side < 0)
            {
                throw new ArgumentException("Radius cannot be negative!");
            }
            else
            {
                return Math.Round(2 * Math.PI * given_side, 2);
            }
        }

        public override double Area()
        {
            if (given_side < 0)
            {
                throw new ArgumentException("Radius cannot be negative!");
            }
            else
            {
                return Math.Round(Math.PI * given_side * given_side, 2);
            }
        }
    }
}