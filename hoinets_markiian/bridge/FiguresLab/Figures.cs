using FiguresLab.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLab.Figure
{

    public class Triangle : Shape
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide, Color color) : base(color)
        {
            if ((firstSide + secondSide) <= thirdSide || (secondSide + thirdSide) <= firstSide
                || (firstSide + thirdSide) <= secondSide)
            {
                throw new Exception("Sum of two triangle sides should be greater than third side");
            }

            else if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new Exception("Sides can`t have negative values");
            }


            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }

        public override double CalculatePerimeter()
        {
            return (FirstSide + SecondSide + ThirdSide);
        }

        public override double CalculateArea()
        {
            double halfPerimeter = CalculatePerimeter();
            double formulaParameter = (halfPerimeter * (halfPerimeter - FirstSide) *
                (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));

            return Math.Sqrt(formulaParameter);
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side, Color color) : base(color)
        {
            if (side <= 0)
            {
                throw new Exception("Side can`t have negative value");
            }

            this.Side = side;
        }
        public override double CalculatePerimeter()
        {
            return (Side * 4);
        }

        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }
    }

    public class Rectangle : Shape
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Rectangle(double firstSide, double secondSide, Color color) : base(color)
        {
            if (firstSide <= 0 || secondSide <= 0)
            {
                throw new Exception("Sides can`t have negative values");
            }

            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
        }

        public override double CalculatePerimeter()
        {
            return ((FirstSide + SecondSide) * 2);
        }

        public override double CalculateArea()
        {
            return FirstSide * SecondSide;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius , Color color) : base(color)
        {
            if (radius <= 0)
            {
                throw new Exception("Radius can`t have negative value");
            }

            this.Radius = radius;
        }
        public override double CalculatePerimeter()
        {
            return (2 * Math.PI * Radius);
        }

        public override double CalculateArea()
        {
            return (Math.PI * Math.Pow(Radius, 2));
        }
    }
}
