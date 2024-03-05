using System;
using System.IO;

public class Fibonacci
{
    public static int[] GenerateFibonacci(int limit, int start1, int start2, out int[] seriesWithoutStart)
    {
        if (limit <= 0 || start1 < 0 || start2 < 0)
        {
            throw new ArgumentException("Limit and start numbers must be positive, and limit must be greater than 0.");
        }

        if (start1 > limit && start2 > limit)
        {
            throw new ArgumentException("Start numbers cannot be greater than the limit.");
        }

        int[] fibonacciSeries = new int[1000];
        fibonacciSeries[0] = start1;
        fibonacciSeries[1] = start2;

        int index = 2;
        while (true)
        {
            fibonacciSeries[index] = fibonacciSeries[index - 1] + fibonacciSeries[index - 2];
            if (fibonacciSeries[index] > limit)
            {
                break;
            }
            index++;
        }
        int[] result = new int[index];
        Array.Copy(fibonacciSeries, result, index);
        seriesWithoutStart = new int[index - 2];
        Array.Copy(result, 2, seriesWithoutStart, 0, index - 2);

        return result;
    }

    public static int GetStepsCount(int[] fibonacciSeries)
    {
        return fibonacciSeries.Length - 2;
    }

    public static void Main(string[] args)
    {
        try
        {
            string filePath = "C:\\Users\\User\\source\\repos\\ConsoleApp1\\ConsoleApp1\\fibonacci_data.txt";
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 3)
            {
                Console.WriteLine("Invalid data format in the file. Expected: limit, start1, start2");
                return;
            }

            int limit = int.Parse(lines[0]);
            int start1 = int.Parse(lines[1]);
            int start2 = int.Parse(lines[2]);

            int[] fibonacciSeries = GenerateFibonacci(limit, start1, start2, out int[] seriesWithoutStart);

            Console.WriteLine("Number: " + string.Join(" ", fibonacciSeries));
            Console.WriteLine("Steps: " + GetStepsCount(fibonacciSeries));
            Console.WriteLine("A row without starting numbers: " + string.Join(" ", seriesWithoutStart));
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid data format in the file.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Mistake: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
