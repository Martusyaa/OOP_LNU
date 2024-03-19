public interface IColor
{
    string FillColor();
}

public class RedColor : IColor
{
    public string FillColor()
    {
        return "Red";
    }
}

public class BlueColor : IColor
{
    public string FillColor()
    {
        return "Blue";
    }

}

public class YellowColor : IColor
{
    public string FillColor()
    {
        return "Yellow";
    }
}
public class GreenColor : IColor
{
    public string FillColor()
    {
        return "Green";
    }
}