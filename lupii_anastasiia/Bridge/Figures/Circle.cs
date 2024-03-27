using System;

﻿namespace Bridge

{
    public class Circle : Figure
    {
        private  double radius;

        public Circle(Color color, double radius) : base(color)
        {
            if (radius <= 0)
            {
              throw new ArgumentException("Circle radius cannot be 0 or negative.", nameof(radius));
            }
            this.radius = radius;
        }
            public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
    }
}


