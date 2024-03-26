namespace Observer;

public class User : IObserver
{
    private string name;

    public User(string name)
    {
        this.name = name;
    }

    public void Notify(string news)
    {
        Console.WriteLine($"Користувач {name} отримав сповіщення: {news}");
    }
}