using System.Text;

namespace Observer;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        User user1 = new User("Петро");
        User user2 = new User("Олена");
        
        NewsCategory sportsCategory = new NewsCategory();
        
        sportsCategory.AddObserver(user1);
        sportsCategory.AddObserver(user2);
        
        sportsCategory.PublishNews("Новий рекорд у бігу на 100 метрів!");
        
        sportsCategory.RemoveObserver(user1);

        sportsCategory.PublishNews("Зміни у складі футбольної команди!");
    }
}