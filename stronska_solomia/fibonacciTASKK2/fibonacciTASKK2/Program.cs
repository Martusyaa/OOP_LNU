using System;
using System.IO;

class Fibonacci
{
    private int firstNumber;
    private int secondNumber;
    private int stepsLimit;
    private int steps;

    public Fibonacci(int first, int second, int stepsLimit)
    {
        firstNumber = first;
        secondNumber = second;
        this.stepsLimit = stepsLimit;
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

        if (steps >= stepsLimit)
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
        int start1, start2, stepsLimit;

        try
        {
            string filePath = @"C:\C#\fibonacci2\data.txt"; 

            using (StreamReader reader = new StreamReader(filePath))
            {
                if (!int.TryParse(reader.ReadLine(), out start1) ||
                    !int.TryParse(reader.ReadLine(), out start2) ||
                    !int.TryParse(reader.ReadLine(), out stepsLimit))
                {
                    Console.WriteLine("Помилка при зчитуванні даних з файлу. Перевірте формат даних.");
                    return;
                }
            }

            Fibonacci fib = new Fibonacci(start1, start2, stepsLimit);
            fib.GenerateFibonacciSeries();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}