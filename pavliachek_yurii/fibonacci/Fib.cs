using System;
using System.Collections.Generic;
using System.IO;

namespace fibonacci_one_two
{
    public class NumbersReader
    {
        public List<int> ReadNumbersFromFile(string filePath)
        {
            List<int> numbers = new List<int>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] tokens = line.Split(' ');
                        foreach (string token in tokens)
                        {
                            if (int.TryParse(token, out int number))
                            {
                                numbers.Add(number);
                            }
                            else
                            {
                                Console.WriteLine($"Failed to parse '{token}' as an integer.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }

            return numbers;
        }
    }
    public class Fib
    {
        List<int> numbers = new List<int>();
        public Fib(List<int> numbers)
        {
            this.numbers = numbers;
        }
        public void Calculatewithlimit()
        {
            try
            {
                string readText = File.ReadAllText("Limit.txt");
                int limit = int.Parse(readText);
                int i = 0;
                while (true)
                {
                    int value = CalculateFibonacci(i);
                    if (value > limit)
                        break;

                    Console.WriteLine(value);
                    i++;
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }

        }
        public void Calculatewithsteps()
        {
            try
            {
                string readText = File.ReadAllText("Steps.txt");
                int step = int.Parse(readText);
                for (int i = 0; i < step; i++)
                {
                    int value = CalculateFibonacci(i);
                    Console.WriteLine($"{i + 1}: {value}");
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }

        }
        private int CalculateFibonacci(int n)
        {
            while (numbers.Count <= n)
            {
                int newValue = numbers[numbers.Count - 1] + numbers[numbers.Count - 2];
                numbers.Add(newValue);
            }
            return numbers[n];
        }
    }
}