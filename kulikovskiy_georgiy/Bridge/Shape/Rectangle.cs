namespace Bridge
{
    public class Rectangle : Shape
    {
        public double SideTwo { get; set; }

        public Rectangle(double sideOne, double sideTwo, IColor color)
            : base(sideOne, color)
        {
            SideTwo = sideTwo;
        }

        public override double Area()
        {
            return SideOne * SideTwo;
        }

        public override double Perimeter()
        {
            return 2 * (SideOne + SideTwo);
        }

        public override string ToString()
        {
            return $"Прямокутник: "
                + $"сторона one: {SideOne},"
                + $"сторона two: {SideTwo}, "
                + $"периметр: {Perimeter()}, "
                + $"площа: {Area()}, "
                + $"колір: {Color.GetColor()}";
        }
    }
}
