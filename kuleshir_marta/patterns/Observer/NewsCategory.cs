namespace Observer;

public class NewsCategory
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void PublishNews(string news)
    {
        foreach (var observer in observers)
        {
            observer.Notify(news);
        }
    }
}