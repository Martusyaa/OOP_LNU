using System;
using System.Collections.Generic;

public abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public abstract void Display(int depth);
}

// Клас листка (листка файлової системи)
public class Leaf : Component
{
    public Leaf(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);
    }
}

// Клас контейнера (папка файлової системи)
public class Composite : Component
{
    private List<Component> children = new List<Component>();

    public Composite(string name) : base(name) { }

    public void Add(Component component)
    {
        children.Add(component);
    }

    public void Remove(Component component)
    {
        children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);

        foreach (var component in children)
        {
            component.Display(depth + 2);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Composite root = new Composite("C:");
        root.Add(new Leaf("Program Files"));
        root.Add(new Leaf("Windows"));

        Composite users = new Composite("Users");
        users.Add(new Leaf("John"));
        users.Add(new Leaf("Alice"));
        root.Add(users);

        root.Display(0);
    }
}
