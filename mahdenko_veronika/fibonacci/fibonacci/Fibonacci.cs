using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace fibonacci
{
    public static class FibonacciCalculator
    {
        public static int steps;
        private static List<int> fibonacciNumbers;
        public static int SSteps;
        private static List<int> Numbers;

        static FibonacciCalculator()
        {
            steps = 0;
            SSteps = 0;
            fibonacciNumbers = new List<int>();
            Numbers = new List<int>();
        }

        public static List<int> CalculateFibonacci(List<int> initialNumbers, int maxNumber)
        {
            if (initialNumbers.Count < 2)
            {
                return fibonacciNumbers;
            }

            Console.Write($"First numbers: {initialNumbers[0]}, {initialNumbers[1]}");

            FibonacciRecursive(initialNumbers, maxNumber);

            Console.WriteLine();

            return fibonacciNumbers;
        }

        private static void FibonacciRecursive(List<int> sequence, int maxNumber)
        {
            int length = sequence.Count;

            int nextNumber = sequence[length - 1] + sequence[length - 2];

            if (nextNumber > maxNumber)
                return;

            steps++;
            fibonacciNumbers.Add(nextNumber);

            sequence.Add(nextNumber);

            FibonacciRecursive(sequence, maxNumber);
        }

        public static List<int> FibonacciLine
        {
            get { return Numbers; }
        }

        public static List<int> FibonacciCalculate(List<int> initialNumbers, int SSteps)
        {
            if (initialNumbers.Count < 2 || SSteps <= 0)
            {
                return FibonacciLine;
            }

            Console.Write($"First numbers: {initialNumbers[0]}, {initialNumbers[1]}\n");

            RecursiveFibonacci(initialNumbers, SSteps);

            return FibonacciLine;
        }

        private static void RecursiveFibonacci(List<int> sequence, int SSteps)
        {
            if (SSteps <= 0)
            {
                return;
            }

            int length = sequence.Count;

            int nextNumber = sequence[length - 1] + sequence[length - 2];
            FibonacciLine.Add(nextNumber);

            sequence.Add(nextNumber);

            RecursiveFibonacci(sequence, SSteps - 1);
        }
        public static int Steps => steps;

        public static List<int> FibonacciNumbers => fibonacciNumbers;
    }
}