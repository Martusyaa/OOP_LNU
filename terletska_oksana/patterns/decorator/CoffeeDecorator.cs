abstract class Decorator : ICoffee
{
    protected ICoffee _component;

    public Decorator(ICoffee component)
    {
        this._component = component;
    }

    public virtual string Operation()
    {
        if (this._component != null)
        {
            return this._component.Operation();
        }
        else
        {
            return string.Empty;
        }
    }
}
