using System;
using System.Collections.Generic;
using System.IO;

public class Fibonacci
{
    private List<int> numbers;
    private int limit;
    private int steps;

    public Fibonacci(List<int> numbers, int limit, int steps)
    {
        this.numbers = numbers;
        this.limit = limit;
        this.steps = steps;
    }

    public void algFibLimit(int num_first, int num_second, int count)
    {
        if (count == 0)
        {
            Console.WriteLine("Fibonacci Limit:");
            Console.Write(num_first + " " + num_second + " ");
            numbers.Add(num_first);
            numbers.Add(num_second);
        }

        int fib_num = num_first + num_second;
        if (fib_num >= limit)
        {
            Console.WriteLine("\nSteps taken to reach the limit: " + count);
            return;
        }

        Console.Write(fib_num + " ");
        numbers.Add(fib_num);
        algFibLimit(num_second, fib_num, count + 1);
    }

    public void algFibSteps(int num_first, int num_second, int count)
    {
        if (count == 0)
        {
            Console.WriteLine("Fibonacci Steps:");
            Console.Write(num_first + " " + num_second + " ");
            numbers.Add(num_first);
            numbers.Add(num_second);
        }

        int fib_num = num_first + num_second;
        if (count >= steps)
        {
            Console.WriteLine("\nSteps taken to reach the limit: " + count);
            return;
        }

        Console.Write(fib_num + " ");
        numbers.Add(fib_num);
        algFibSteps(num_second, fib_num, count + 1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(Array.ConvertAll(File.ReadAllLines("num.txt"), int.Parse));
        int limit = int.Parse(File.ReadAllText("limit.txt"));
        int steps = int.Parse(File.ReadAllText("steps.txt"));

        Fibonacci fibonacci = new Fibonacci(numbers, limit, steps);
        fibonacci.algFibLimit(numbers[0], numbers[1], 0);
        fibonacci.algFibSteps(numbers[0], numbers[1], 0);
    }
}

