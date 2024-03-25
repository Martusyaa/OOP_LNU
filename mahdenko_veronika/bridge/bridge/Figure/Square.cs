using System.Drawing;

namespace Bridge
{
    public class Square : Rectangle
    {
        public Square(Color color, double given_side) : base(color, given_side, given_side)
        {
        }
    }
}
