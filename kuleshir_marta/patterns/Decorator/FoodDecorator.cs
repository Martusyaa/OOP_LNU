namespace Decorator;

abstract class FoodDecorator : IFood
{
    protected IFood _food;

    public FoodDecorator(IFood food)
    {
        _food = food;
    }

    public virtual string Prepare()
    {
        if (_food != null)
            return _food.Prepare();
        else
            return string.Empty;
    }
}