using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace fibonacci
{
    class Program
    {
        static void Main()
        {
            try
            {
                int maxNumber = int.Parse(File.ReadAllText("MaxNumber.txt"));
                string firstNumbersText = File.ReadAllText("FirstNumbers.txt");
                string[] firstNumbersArray = firstNumbersText.Split(',');

                List<int> inputNumbers = firstNumbersArray.Select(int.Parse).ToList();

                Console.WriteLine("Fibonacci1");
                List<int> fibonacciLine = FibonacciCalculator.CalculateFibonacci(inputNumbers, maxNumber);
                Console.WriteLine($"Fibonacci Sequence: {string.Join(", ", fibonacciLine)}");
                Console.WriteLine($"Fibonacci steps: {FibonacciCalculator.Steps} \n");

                FibonacciCalculator.steps = 0;
                int steps = int.Parse(File.ReadAllText("CountSteps.txt"));
                int firstNumber = int.Parse(firstNumbersArray[0]);
                int secondNumber = int.Parse(firstNumbersArray[1]);

                Console.WriteLine("Fibonacci2");
                List<int> fibonacciLinee = FibonacciCalculator.FibonacciCalculate(new List<int> { firstNumber, secondNumber }, steps);
                Console.WriteLine($"Fibonacci Sequence: {string.Join(", ", fibonacciLinee)}");
                Console.WriteLine($"Fibonacci steps: {steps}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
