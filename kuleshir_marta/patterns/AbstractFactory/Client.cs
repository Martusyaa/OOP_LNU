namespace AbstractFactory;

public class Client
    {
        private readonly ICarFactory _factory;

        public Client(ICarFactory factory)
        {
            _factory = factory;
        }

        public void DriveCar()
        {
            ISedan sedan = _factory.CreateSedan();
            ICrossover crossover = _factory.CreateCrossover();

            sedan.Drive();
            crossover.Drive();
        }
    }