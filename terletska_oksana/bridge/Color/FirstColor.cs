using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FirstColor : Color
{
    public override string Draw()
    {
        return "White";
    }
}


namespace Bridge.Color
{
    internal class FirstColor
    {
    }
}
