using System;
using System.IO;

namespace FibonacciOne
{
  public static class InputParser
  {
    public static List<int> ParseToInt(string input)
    {
      List<int> parsedList = new List<int>();

      List<string> numbers = new List<string>(input.Split(" "));

      foreach (string number in numbers)
      {
          int.TryParse(number, out int parsedNumber);
          parsedList.Add(parsedNumber);
      }

      return parsedList;
    }
  }
}
