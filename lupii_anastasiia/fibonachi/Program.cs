using System;
using System.Collections.Generic;

public class Fibonacci
{
    public List<int> Sequence { get; private set; }
    public int Steps { get; private set; }

    public Fibonacci()
    {
        Sequence = new List<int>();
        Steps = 0;
    }

    public void GenerateUpToLimit(int a, int b, int limit)
    {
        if (Sequence.Count == 0)
        {
            Sequence.Add(a);
            if (b <= limit)
            {
                Sequence.Add(b);
            }
        }

        int next = a + b;
        if (next > limit) return;

        Sequence.Add(next);
        Steps++;
        GenerateUpToLimit(b, next, limit);
    }

    public void GenerateBySteps(int a, int b, int maxSteps)
    {
        if (Steps == 0)
        {
            Sequence.Add(a);
            Sequence.Add(b);
        }
        else if (Steps >= maxSteps) return;

        int next = a + b;
        Sequence.Add(next);
        Steps++;
        if (Steps < maxSteps)
        {
            GenerateBySteps(b, next, maxSteps);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        int border = 0;
        int steps = 0;

        List<int> startNumber = new List<int>();

        using (StreamReader numbersFile = File.OpenText("startNumber.txt"))
        {
            
            string numbersLine = numbersFile.ReadLine();
            Array.ForEach(numbersLine.Split(' '), number => startNumber.Add(int.Parse(number)));
        }
        using (StreamReader stepsFile = File.OpenText("numberOfStep.txt"))
        {
            steps = int.Parse(stepsFile.ReadLine());
        }
        using (StreamReader borderFile = File.OpenText("numberOfBorder.txt"))
        {
            border = int.Parse(borderFile.ReadLine());
        }
        Fibonacci fib1 = new Fibonacci();
        fib1.GenerateUpToLimit(startNumber[0], startNumber[1], border);
        Console.WriteLine($"Limit Method:\nSequence: {string.Join(" ", fib1.Sequence)}\nSteps: {fib1.Steps}");

        Fibonacci fib2 = new Fibonacci();
        fib2.GenerateBySteps(startNumber[0], startNumber[1], steps);
        Console.WriteLine($"\nSteps Method:\nSequence: {string.Join(" ", fib2.Sequence)}\nSteps: {fib2.Steps}");
    }
}
