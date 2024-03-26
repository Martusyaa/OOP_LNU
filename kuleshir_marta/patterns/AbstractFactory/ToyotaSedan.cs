namespace AbstractFactory;

public class ToyotaSedan : ISedan
{
    public void Drive()
    {
        Console.WriteLine("Driving Toyota Sedan");
    }
}