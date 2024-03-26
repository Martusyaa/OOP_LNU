namespace Decorator;

class SpiceDecorator : FoodDecorator
{
    public SpiceDecorator(IFood food) : base(food)
    {
    }

    public override string Prepare()
    {
        return $"{base.Prepare()} + Spice";
    }
}