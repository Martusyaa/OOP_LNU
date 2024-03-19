using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    abstract public class Color
    {
        public abstract string FillColor();

    }

    public class Red : Color
    {
        public override string FillColor()
        {
            return "Red";
        }
    }

    public class Blue : Color
    {
        public override string FillColor()
        {
            return "Blue";
        }
    }

    public class Green : Color
    {
        public override string FillColor()
        {
            return "Green";
        }
    }

}
