namespace Bridge
{
  public class Square : Rectangle
  {
    public Square(double sideOne, IColor color)
        : base(sideOne, sideOne, color) { }

    public override string ToString()
    {
      return "Square: "
          + $"side: {SideOne}, "
          + $"perimeter: {Perimeter()}, "
          + $"area: {Area()}, "
          + $"color: {Color.GetColor()}";
    }
  }
}
