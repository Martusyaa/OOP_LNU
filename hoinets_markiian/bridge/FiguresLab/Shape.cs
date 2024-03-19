using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLab.Figure
{
    public abstract class Shape
    {
        protected Color _color;

        public Shape(Color color)
        {
            this._color = color;
        }

        public void ShowColor()
        {
            Console.WriteLine(_color.ReturnColor());
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();
    }

}
