public class Program
{
    public static void Main(string[] args)
    {
        CarBuilder builder = new CarBuilder("Ford");

        ICar car = builder.SetColor("Dark blue").SetDoors(4).Build();

        Console.WriteLine("Model: " + car.GetModel());
        Console.WriteLine("Color: " + car.GetColor());
        Console.WriteLine("Doors: " + car.GetDoors());
    }
}
