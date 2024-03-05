using System;
using System.IO;

class Fibonacci
{
    private int firstNumber;
    private int secondNumber;
    private int limit;
    private int steps;

    public Fibonacci(int first, int second, int limit)
    {
        firstNumber = first;
        secondNumber = second;
        this.limit = limit;
        steps = 0; 
    }

    public void GenerateFibonacciSeries()
    {
        Console.Write($"Ряд: {firstNumber} {secondNumber} ");
        GenerateNextFibonacci(firstNumber, secondNumber);
        Console.WriteLine($"\nКроків: {steps}");
    }

    private void GenerateNextFibonacci(int a, int b)
    {
        int next = a + b;

        if (next > limit)
            return;

        Console.Write($"{next} ");
        steps++;

        GenerateNextFibonacci(b, next);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int start1, start2, limit;

        try
        {
            string filePath = @"C:\C#\fibonacci1\data.txt"; 
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] data = reader.ReadToEnd().Split('\n');

                if (data.Length < 3)
                {
                    Console.WriteLine("Недостатньо даних у файлі.");
                    return;
                }

                if (!int.TryParse(data[0], out start1) ||
                    !int.TryParse(data[1], out start2) ||
                    !int.TryParse(data[2], out limit))
                {
                    Console.WriteLine("Помилка при зчитуванні даних з файлу. Перевірте формат даних.");
                    return;
                }
            }

            Fibonacci fib = new Fibonacci(start1, start2, limit);
            fib.GenerateFibonacciSeries();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}