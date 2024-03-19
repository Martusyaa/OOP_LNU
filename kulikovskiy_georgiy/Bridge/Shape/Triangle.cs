namespace Bridge
{
    public class Triangle : Shape
    {
        public double SideTwo { get; set; }
        public double SideThree { get; set; }

        public Triangle(double sideOne, double sideTwo, double sideThree, IColor color)
            : base(sideOne, color)
        {
            SideTwo = sideTwo;
            SideThree = sideThree;
        }

        public override double Perimeter()
        {
            return SideOne + SideTwo + SideThree;
        }

        public override double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            return Math.Sqrt(
                semiPerimeter
                    * (semiPerimeter - SideOne)
                    * (semiPerimeter - SideTwo)
                    * (semiPerimeter - SideThree)
            );
        }

        public override string ToString()
        {
            return "Triangle: "
                + $"side one: {SideOne}, "
                + $"side two: {SideTwo}, "
                + $"side three: {SideThree}, "
                + $"perimeter: {Perimeter()}, "
                + $"area: {Area()}, "
                + $"color: {Color.GetColor()}";
        }
    }
}
