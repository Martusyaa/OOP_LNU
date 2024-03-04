using System;
using static FibonacciOne.Fibonacci;
using static FibonacciOne.InputRead;
using static FibonacciOne.FibonacciCalculate;
using static FibonacciOne.InputParser;

namespace FibonacciOne
{
  class Program
  {
    static void Main(string[] args)
    {
      InputRead fileRead = new InputRead("./input.txt");
      List<int> intList = new List<int>(InputParser.ParseToInt(fileRead.ReadFromFile()));
      Fibonacci fibOne = new Fibonacci(0, intList);
      System.Console.WriteLine("Границя: ");
      System.Console.WriteLine(FibonacciCalculate.CalculateLimit(10, fibOne));
      System.Console.WriteLine("Кроки: ");
      System.Console.WriteLine(FibonacciCalculate.CalculateSteps(10, fibOne));
    }
  }
}
