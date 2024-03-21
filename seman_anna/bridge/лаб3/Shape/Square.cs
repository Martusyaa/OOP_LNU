using System;

public class Square : Rectangle
{
    public Square(string color, double side) : base(color, side, side) { }

    public override string Draw()
    {
        return $"Draw a {color} square";
    }
}