namespace Decorator;

class SauceDecorator : FoodDecorator
{
    public SauceDecorator(IFood food) : base(food)
    {
    }

    public override string Prepare()
    {
        return $"{base.Prepare()} + Sauce";
    }
}