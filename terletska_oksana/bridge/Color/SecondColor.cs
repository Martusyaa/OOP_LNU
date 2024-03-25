using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SecondColor : Color
{
    public override string Draw()
    {
        return "Blue";
    }
}



namespace Bridge.Color
{
    internal class SecondColor
    {
    }
}
