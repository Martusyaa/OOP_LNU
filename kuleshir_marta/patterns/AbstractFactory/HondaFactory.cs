namespace AbstractFactory;

public class HondaFactory : ICarFactory
{
    public ISedan CreateSedan()
    {
        return new HondaSedan();
    }

    public ICrossover CreateCrossover()
    {
        return new HondaCrossover();
    }
}