using System;
using System.IO;

static class Fibonacci
{
    public static void GenerateSeries(int a, int b, int stepsValue)
    {
        int steps = 0;

        Console.Write($"Ряд: {a} {b}");
        GenerateSeriesRecursive(a, b, stepsValue, ref steps);
        Console.WriteLine($"\nКроків: {steps}");
    }

    private static void GenerateSeriesRecursive(int a, int b, int stepsValue, ref int steps)
    {
        int next = a + b;
        steps++;

        Console.Write($" {next}");
        if (steps < stepsValue)
        {
            GenerateSeriesRecursive(b, next, stepsValue, ref steps);
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            if (!File.Exists("input.txt"))
            {
                throw new FileNotFoundException("Файл 'input.txt' не знайдено.");
            }

            string[] lines = File.ReadAllLines("input.txt");

            if (lines.Length < 3)
            {
                throw new ArgumentException("Недостатньо даних у файлі.");
            }

            if (!int.TryParse(lines[0], out int steps) || steps <= 0)
            {
                throw new ArgumentException("Кількість кроків повинна бути цілим числом більше 0.");
            }

            if (!int.TryParse(lines[1], out int start1))
            {
                throw new ArgumentException("Перше число повинно бути цілим числом.");
            }

            if (!int.TryParse(lines[2], out int start2))
            {
                throw new ArgumentException("Друге число повинно бути цілим числом.");
            }

            Fibonacci.GenerateSeries(start1, start2, steps);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
    }
}
