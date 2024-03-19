namespace Bridge
{
    public abstract class Shape
    {
        protected Color color;

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract string GetColor();
        public abstract double Perimeter();
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        private int side_a;
        private int side_b;

        public Rectangle(int a, int b, Color color) : base(color)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Error: Side lengths cannot be negative");
            }
            side_a = a;
            side_b = b;
        }

        public override string GetColor()
        {
            return color.ColorName;
        }

        public override double Perimeter()
        {
            return 2 * (side_a + side_b);
        }

        public override double Area()
        {
            return side_a * side_b;
        }
    }

    public class Square : Rectangle
    {
        private int side;

        public Square(int a, Color color) : base(a, a, color)
        {
            if (a < 0)
            {
                throw new ArgumentException("Error: Side length cannot be negative");
            }
            side = a;
        }

        public override string GetColor()
        {
            return color.ColorName;
        }
    }
    public class Circle : Shape
    {
        private int radius;

        public Circle(int a, Color color) : base(color)
        {
            if(a < 0)
            {
                throw new ArgumentException("Error: Side length cannot be negative");
            }
            radius = a;
        }
        public override string GetColor()
        {
            return color.ColorName;
        }
        public override double Area()
        {
            return 3.14 * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
    public class Triangle : Shape
    {
        private int side_a;
        private int side_b;
        private int side_c;

        public Triangle(int a, int b, int c, Color color) : base(color)
        {
            if(a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Error: Sides length cannot be negative");
            }
            side_a = a;
            side_b = b;
            side_c = c;
        }
        public override string GetColor()
        {
            return color.ColorName;
        }
        public override double Area()
        {
            return 0.5 * side_a * side_b;
        }
        public override double Perimeter()
        {
            return side_a + side_b + side_c;
        }
    }
}
