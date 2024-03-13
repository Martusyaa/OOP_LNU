using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Recursion
{
    static void Main()
    {
        const string firstFilepath = "TargetNum.txt";
        const string secondFilepath = "Steps.txt";
        const string thirdFilepath = "StartPoints.txt";
        string fileContaining = null;

        if (!File.Exists(firstFilepath) || !File.Exists(secondFilepath) || !File.Exists(thirdFilepath))
        {
            throw new FileNotFoundException("File not found");
        }

        int target = Int32.Parse(File.ReadAllText(firstFilepath));
        int steps = Int32.Parse(File.ReadAllText(secondFilepath));
        fileContaining = File.ReadAllText(thirdFilepath);

        List<int> values = fileContaining.Split(",").Select(int.Parse).ToList();

        List<int> fibonacciNumbers = Fibonachi(values.ToList(), target);
        Console.WriteLine("Target: " + target);
        Console.WriteLine("Fibonacci Numbers: ");

        foreach (var num in fibonacciNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nSteps: " + steps);

        List<int> FibonachiNumStep = FibonachiStep(values.ToList(), steps);
        Console.WriteLine("Fibonachi Number Step: ");

        foreach (var num in FibonachiNumStep)
        {
            Console.Write(num + " ");
        }
    }

    public static List<int> Fibonachi(List<int> values, int target)
    {
        int count = values.Count;
        int nextNumber = values[count - 1] + values[count - 2];

        if (target > nextNumber)
        {
            values.Add(nextNumber);
            return Fibonachi(values, target);
        }

        return values;
    }

    public static List<int> FibonachiStep(List<int> values, int step)
    {
        int count = values.Count;
        int nextNumber = values[count - 1] + values[count - 2];

        if (count < step + 2)
        {
            values.Add(nextNumber);
            return FibonachiStep(values, step);
        }

        return values;
    }
}
