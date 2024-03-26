public class CarBuilder
{
    private string model;
    private string color;
    private int doors;

    public CarBuilder(string model)
    {
        this.model = model;
    }

    public CarBuilder SetColor(string color)
    {
        this.color = color;
        return this;
    }

    public CarBuilder SetDoors(int doors)
    {
        this.doors = doors;
        return this;
    }

    public ICar Build()
    {
        return new Car(model, color, doors);
    }
}
