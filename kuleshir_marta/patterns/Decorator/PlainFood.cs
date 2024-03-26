namespace Decorator;

class PlainFood : IFood
{
    public string Prepare()
    {
        return "Plain Food";
    }
}