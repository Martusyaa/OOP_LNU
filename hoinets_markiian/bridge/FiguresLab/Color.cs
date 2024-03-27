using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLab.Figure
{
    public abstract class Color
    {
        public abstract string ReturnColor();
    }

    public class Red : Color
    {
        public override string ReturnColor()
        {
            return "Color is red";
        }
    }

    public class Yellow : Color
    {
        public override string ReturnColor()
        {
            return "Color is yellow";
        }
    }

    public class Blue : Color
    {
        public override string ReturnColor()
        {
            return "Color is blue";
        }
    }
}
