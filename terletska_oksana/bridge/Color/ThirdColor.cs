using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ThirdColor : Color
{
    public override string Draw()
    {
        return "Purple";
    }
}



namespace Bridge.Color
{
    internal class ThirdColor
    {
    }
}
