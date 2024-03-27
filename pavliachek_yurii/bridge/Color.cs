namespace Bridge
{
    public abstract class Color
    {
        public abstract string ColorName { get; }
    }

    public class Orange : Color
    {
        public override string ColorName => "Orange";
    }

    public class Blue : Color
    {
        public override string ColorName => "Blue";
    }
    public class Red : Color
    {
        public override string ColorName => "Red";
    }
    public class Yellow : Color
    {
        public override string ColorName => "Yellow";
    }
}
