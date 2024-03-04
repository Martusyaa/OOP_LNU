using System;
using System.IO;

public class Fibonacci
{
    public static int[] GenerateFibonacci(int steps, int start1, int start2)
    {
        if (steps <= 0)
            throw new ArgumentException("Number of steps must be greater than 0.");

        int[] fibonacciSeries = new int[steps];
        fibonacciSeries[0] = start1;
        fibonacciSeries[1] = start2;

        GenerateFibonacciRecursive(steps - 2, start1, start2, fibonacciSeries, 2);

        return fibonacciSeries;
    }

    private static void GenerateFibonacciRecursive(int steps, int num1, int num2, int[] series, int currentIndex)
    {
        if (steps == 0)
            return;

        int nextNum = num1 + num2;
        series[currentIndex] = nextNum;
        GenerateFibonacciRecursive(steps - 1, num2, nextNum, series, currentIndex + 1);
    }

    public static void Main(string[] args)
    {
        try
        {
            string filePath = "C:\\Users\\User\\source\\repos\\fiobnacci2\\fiobnacci2\\fibon.txt";
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length < 3)
            {
                Console.WriteLine("Invalid data format in the file. Expected: steps, start1, start2");
                return;
            }

            int steps = int.Parse(lines[0]);
            int start1 = int.Parse(lines[1]);
            int start2 = int.Parse(lines[2]);

            int[] fibonacciSeries = GenerateFibonacci(steps, start1, start2);

            Console.WriteLine("Fibonacci Series: " + string.Join(" ", fibonacciSeries));
            Console.WriteLine("Steps: " + steps);
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
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
