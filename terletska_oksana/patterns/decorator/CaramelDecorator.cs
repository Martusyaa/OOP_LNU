class CaramelDecorator : Decorator
{
    public CaramelDecorator(ICoffee comp) : base(comp)
    {
    }

    public override string Operation()
    {
        return $"{base.Operation()}, Caramel";
    }
}
