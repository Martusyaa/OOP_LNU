using System;

public interface ICar
{
    string GetModel();
    string GetColor();
    int GetDoors();
}

public class Car : ICar
{
    private string model;
    private string color;
    private int doors;

    public Car(string model, string color, int doors)
    {
        this.model = model;
        this.color = color;
        this.doors = doors;
    }

    public string GetModel() { return model; }
    public string GetColor() { return color; }
    public int GetDoors() { return doors; }
}
