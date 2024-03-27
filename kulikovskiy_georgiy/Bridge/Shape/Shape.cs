namespace Bridge
{
  public abstract class Shape
  {
    private double sideOne;
    private IColor color;

    public Shape(double sideOne, IColor color)
    {
      this.sideOne = sideOne;
      this.color = color;
    }

    public double SideOne
    {
      get
      {
        return this.sideOne;
      }

      set
      {
        this.sideOne = value;
      }
    }

    public IColor Color
    {
      get
      {
        return this.color;
      }

      set
      {
        this.color = value;
      }
    }
    public abstract double Area();

    public abstract double Perimeter();
  }
}
