namespace AbstractFactory;

public class HondaSedan : ISedan
{
    public void Drive()
    {
        Console.WriteLine("Driving Honda Sedan");
    }
}