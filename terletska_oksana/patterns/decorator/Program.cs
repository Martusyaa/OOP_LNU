using System;

public interface ICoffee
{
    string Operation();
}

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        var simple = new SimpleCoffee();
        Console.WriteLine("Client: I get a simple component:");
        client.ClientCode(simple);
        Console.WriteLine();

        MilkDecorator decorator1 = new MilkDecorator(simple);
        CaramelDecorator decorator2 = new CaramelDecorator(decorator1);
        Console.WriteLine("Client: Now I've got a decorated component:");
        client.ClientCode(decorator2);
    }
}
