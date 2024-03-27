using System;

namespace Shapes
{
    abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }
      
        public abstract void Draw();
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
