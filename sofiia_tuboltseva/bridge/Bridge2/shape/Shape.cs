using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    // Abstraction
    abstract class Shape
    {
        protected IColor color;//захищене

        public Shape(IColor color)
        {
            this.color = color;//this посилання
        }

        public abstract void Draw();
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
