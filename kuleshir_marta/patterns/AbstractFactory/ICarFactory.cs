namespace AbstractFactory;

public interface ICarFactory
{
    ISedan CreateSedan();
    ICrossover CreateCrossover();
}