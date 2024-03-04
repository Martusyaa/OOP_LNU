using System;
using System.IO;

class Fibonacci
{
    static void Main(string[] args)
    {
        try
        {
            string boundaryFile = @"C:\Sofia\prog and crypto\fibonachi\fibonachi\boundary.txt";
            string startNumbersFile = @"C:\Sofia\prog and crypto\fibonachi\fibonachi\start_number.txt";
            string stepsFile = @"C:\Sofia\prog and crypto\fibonachi\fibonachi\steps.txt";

            int boundary = ReadIntegerFromFile(boundaryFile);
            int[] startNumbers = ReadTwoIntegersFromFile(startNumbersFile);
            int steps = ReadIntegerFromFile(stepsFile);

            int[] fibSeries = GenerateFibonacciSeries(boundary, startNumbers[0], startNumbers[1], steps);

            Console.WriteLine("Fibonacci row:");
            foreach (int num in fibSeries)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nSteps: " + fibSeries.Length);
        }
        catch (Exception e)
        {
            Console.WriteLine("error: " + e.Message);
        }
    }

    public static int ReadIntegerFromFile(string fileName)
    {
        using (StreamReader sr = new StreamReader(fileName))
        {
            return int.Parse(sr.ReadLine());
        }
    }

    public static int[] ReadTwoIntegersFromFile(string fileName)
    {
        int[] numbers = new int[2];
        using (StreamReader sr = new StreamReader(fileName))
        {
            string line = sr.ReadLine();
            if (line != null)
            {
                numbers[0] = int.Parse(line);
            }
            else
            {
                throw new InvalidDataException("error " + fileName + " error");
            }

            line = sr.ReadLine();
            if (line != null)
            {
                numbers[1] = int.Parse(line);
            }
            else
            {
                throw new InvalidDataException("error " + fileName + " error");
            }
        }
        return numbers;
    }




    public static int[] GenerateFibonacciSeries(int boundary, int a = 0, int b = 1, int count = 2)
    {
        int[] number = new int[count];
        if (boundary <= 0 || count == 0)
        {
            return new int[0];
        }

        if (count <= 2)
        {
            return new int[] { a, b };
        }

        List<int> series = new List<int> { a, b };
        for (int i = 2; i < count && b < boundary; i++)
        {
            int next = a + b;
            if (next > boundary)
            {
                break;
            }
            series.Add(next);
            a = b;
            b = next;
        }
        return series.ToArray();
    }
}

