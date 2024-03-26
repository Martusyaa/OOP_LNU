namespace AbstractFactory;

public class ToyotaFactory : ICarFactory
{
    public ISedan CreateSedan()
    {
        return new ToyotaSedan();
    }

    public ICrossover CreateCrossover()
    {
        return new ToyotaCrossover();
    }
}