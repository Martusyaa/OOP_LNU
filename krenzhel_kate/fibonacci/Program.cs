using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<int> sequenceSteps = new List<int>();
        List<int> sequenceBorder = new List<int>();
        double steps = 0;
        double border = 0;
        using (StreamReader numbersFile = File.OpenText("Numbers.txt"))
        {
            string numbersLine = numbersFile.ReadLine();
            Array.ForEach(numbersLine.Split(' '), number => sequenceSteps.Add(int.Parse(number)));
            Array.ForEach(numbersLine.Split(' '), number => sequenceBorder.Add(int.Parse(number)));
        }
        using (StreamReader stepsFile = File.OpenText("Steps.txt"))
        {
            steps = double.Parse(stepsFile.ReadLine());
        }
        using (StreamReader borderFile = File.OpenText("Border.txt"))
        {
            border = double.Parse(borderFile.ReadLine());
        }
        Fibonacci objBorder = new Fibonacci();
        List<int> resultBorder = objBorder.CalculateFibonacciBorder(border, sequenceBorder);
        Console.WriteLine("ListBorder: " + string.Join(", ", resultBorder));
        Fibonacci objSteps = new Fibonacci();
        List<int> resultSteps = objSteps.CalculateFibonacciSteps(steps, sequenceSteps);
        Console.WriteLine("ListSteps: " + string.Join(", ", resultSteps));
        
        
    }
}

