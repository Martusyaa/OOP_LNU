using System;
using System.Collections.Generic;
using System.IO;

class Fibonacci
{
    private int limit;
    private int firstNumber;
    private int secondNumber;

    public Fibonacci(int limit, int firstNumber, int secondNumber)
    {
        this.limit = limit;
        this.firstNumber = firstNumber;
        this.secondNumber = secondNumber;
    }

    public (List<int> series, int steps) FibonacciWithLimit()
    {
        return FibonacciWithLimit(firstNumber, secondNumber, 1);
    }

    private (List<int> series, int steps) FibonacciWithLimit(int a, int b, int currentStep)
    {
        if (a > limit)
        {
            return (new List<int>(), currentStep - 1);
        }
        else
        {
            var (series, newSteps) = FibonacciWithLimit(b, a + b, currentStep + 1);
            if (b <= limit)
            {
                series.Insert(0, a);
            }
            return (series, newSteps);
        }
    }

    public void SaveResultToFile(string outputFilePath, (List<int> series, int steps) result)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"[Ряд : {string.Join(" ", result.series)}]");
                writer.WriteLine($"Кроків: {result.steps}");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при записі {ex.Message}");
        }
    }

    public static Fibonacci GetFibonacciFromInputFile(string inputFilePath)
    {
        string[] inputLines = File.ReadAllLines(inputFilePath);

        
        int firstNumber = int.Parse(inputLines[0]);
        int secondNumber = int.Parse(inputLines[1]);
        int limitValue = int.Parse(inputLines[2]);

        return new Fibonacci(limitValue, firstNumber, secondNumber);
    }
}

class Program
{
    static void Main()
    {

        var fibonacci = Fibonacci.GetFibonacciFromInputFile(@"C:\Users\User\source\repos\Fib_Maksymiv\Fib_Maksymiv\input.txt");

       
        var result = fibonacci.FibonacciWithLimit();

       
        fibonacci.SaveResultToFile(@"C:\Users\User\source\repos\Fib_Maksymiv\Fib_Maksymiv\output.txt", result);
    }
}
