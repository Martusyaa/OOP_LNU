using System;
using System.IO;

namespace FibonacciOne
{
    public static class FibonacciCalculate
    {
      public static Fibonacci CalculateLimit(int limit, Fibonacci fibonacciInstance)
      {
        List<int> fibonacciSequence = fibonacciInstance.FibonacciSequence;

        if(fibonacciSequence.Last() > limit)
        {
          fibonacciSequence.RemoveAt(fibonacciInstance.FibonacciSequence.Count - 1);
          return fibonacciInstance;
        }

        fibonacciSequence.Add(fibonacciSequence[fibonacciSequence.Count - 2] + fibonacciSequence[fibonacciSequence.Count - 1]);

        return CalculateLimit(limit, fibonacciInstance);
      }

      public static Fibonacci CalculateSteps(int steps, Fibonacci fibonacciInstance)
      {
        List<int> fibonacciSequence = fibonacciInstance.FibonacciSequence;

        if ((fibonacciSequence.Count - 2) == steps)
        {
            return fibonacciInstance;
        }

        fibonacciSequence.Add(fibonacciSequence[fibonacciSequence.Count - 2] + fibonacciSequence[fibonacciSequence.Count - 1]);

        return CalculateSteps(steps, fibonacciInstance);
      }
    }
}
