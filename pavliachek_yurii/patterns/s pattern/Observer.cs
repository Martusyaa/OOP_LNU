using System;
using System.Collections.Generic;

public interface IObserver
{
    void Update(string message);
}

public class ConcreteObserver : IObserver
{
    private string name;

    public ConcreteObserver(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} received a message: {message}");
    }
}

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers(string message);
}

public class ConcreteSubject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IObserver observer1 = new ConcreteObserver("Observer 1");
        IObserver observer2 = new ConcreteObserver("Observer 2");
        IObserver observer3 = new ConcreteObserver("Observer 3");

        ISubject subject = new ConcreteSubject();

        subject.RegisterObserver(observer1);
        subject.RegisterObserver(observer2);
        subject.RegisterObserver(observer3);

        subject.NotifyObservers("The new message!");
    }
}
