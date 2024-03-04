using System;
using System.Collections.Generic;
using System.IO;

class FibonacciWithSteps
{
    private int steps;
    private int firstNumber;
    private int secondNumber;

    public FibonacciWithSteps(int steps, int firstNumber, int secondNumber)
    {
        this.steps = steps;
        this.firstNumber = firstNumber;
        this.secondNumber = secondNumber;
    }

    public List<int> FibonacciSeriesWithSteps()
    {
        return FibonacciSeriesWithSteps(firstNumber, secondNumber, 1, new List<int>());
    }

    private List<int> FibonacciSeriesWithSteps(int a, int b, int currentStep, List<int> series)
    {
        if (currentStep > steps)
        {
            return series;
        }
        else
        {
            series.Add(a);
            return FibonacciSeriesWithSteps(b, a + b, currentStep + 1, series);
        }
    }

    public void SaveResultToFile(string outputFilePath, List<int> series)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"Ряд: {string.Join(" ", series)}");
                writer.WriteLine($"Кроків: {steps}");
            }

            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при записі {ex.Message}");
        }
    }

    public static FibonacciWithSteps GetFibonacciFromInputFile(string inputFilePath)
    {
       
        string[] inputLines;

        try
        {
            inputLines = File.ReadAllLines(inputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при зчитуванні  {ex.Message}");
            return null;
        }

        if (inputLines.Length >= 3)
        {
            
            if (int.TryParse(inputLines[0], out int firstNumber) &&
                int.TryParse(inputLines[1], out int secondNumber) &&
                int.TryParse(inputLines[2], out int stepsValue))
            {
                return new FibonacciWithSteps(stepsValue, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Помилка при конвертації ");
                return null;
            }
        }
        else
        {
            Console.WriteLine("Недостатньо даних");
            return null;
        }
    }
}

class Program
{
    static void Main()
    {
       
        var fibonacciWithSteps = FibonacciWithSteps.GetFibonacciFromInputFile(@"C:\Users\User\source\repos\fib2\input.txt");

        if (fibonacciWithSteps != null)
        {
    
            var series = fibonacciWithSteps.FibonacciSeriesWithSteps();


            fibonacciWithSteps.SaveResultToFile(@"C:\Users\User\source\repos\fib2\output.txt", series);
        }
    }
}
