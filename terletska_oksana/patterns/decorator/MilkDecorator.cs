class MilkDecorator : Decorator
{
    public MilkDecorator(ICoffee comp) : base(comp)
    {
    }

    public override string Operation()
    {
        return $"{base.Operation()}, Milk";
    }
}
