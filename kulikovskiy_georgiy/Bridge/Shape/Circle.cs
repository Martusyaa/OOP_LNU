namespace Bridge
{
    public class Circle : Shape
    {
        public Circle(double sideOne, IColor color)
            : base(sideOne, color) { }

        public override double Area()
        {
            return Math.PI * SideOne * SideOne;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * SideOne;
        }

        public override string ToString()
        {
            return "Circle: "
                + $"side: {SideOne}, "
                + $"length: {Perimeter()}, "
                + $"area: {Area()}, "
                + $"color: {Color.GetColor()}";
        }
    }
}
