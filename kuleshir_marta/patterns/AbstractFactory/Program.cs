namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        ICarFactory hondaFactory = new HondaFactory();
        Client client1 = new Client(hondaFactory);
        client1.DriveCar();

        ICarFactory toyotaFactory = new ToyotaFactory();
        Client client2 = new Client(toyotaFactory);
        client2.DriveCar();
    }
}