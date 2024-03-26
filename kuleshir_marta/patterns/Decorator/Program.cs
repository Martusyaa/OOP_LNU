namespace Decorator;

class Program
{
    static void Main()
    {
        IFood plainFood = new PlainFood();
        Console.WriteLine("Client: Preparing plain food:");
        PrepareFood(plainFood);
        Console.WriteLine();
        
        IFood spicedFood = new SpiceDecorator(new PlainFood());
        Console.WriteLine("Client: Preparing spiced food:");
        PrepareFood(spicedFood);
        Console.WriteLine();
        
        IFood saucyFood = new SauceDecorator(new PlainFood());
        Console.WriteLine("Client: Preparing saucy food:");
        PrepareFood(saucyFood);
        Console.WriteLine();
        
        IFood spicedSaucyFood = new SauceDecorator(new SpiceDecorator(new PlainFood()));
        Console.WriteLine("Client: Preparing spiced and saucy food:");
        PrepareFood(spicedSaucyFood);
    }
    
    public static void PrepareFood(IFood food)
    {
        Console.WriteLine("RESULT: " + food.Prepare());
    }
}