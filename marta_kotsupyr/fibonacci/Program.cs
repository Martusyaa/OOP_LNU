using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int limit = 0;
        int firstNumber = 0, secondNumber = 1;

       using (StreamReader limitReader = new StreamReader("limit.txt"))
        {
            if (File.Exists("limit.txt"))
                limit = int.Parse(limitReader.ReadLine());
        }

        using (StreamReader initialDataReader = new StreamReader("initial_data.txt"))
        {
            if (File.Exists("initial_data.txt"))
            {
                firstNumber = int.Parse(initialDataReader.ReadLine());
                secondNumber = int.Parse(initialDataReader.ReadLine());
            }
        }

        Console.WriteLine("Choose algorithm: (1) Fibonacci with limit, (2) Fibonacci with steps");
        int choice = int.Parse(Console.ReadLine());

        Fibonacci fib = new Fibonacci(firstNumber, secondNumber);

        if (choice == 1)
        {
            Console.WriteLine("Limit read from file: " + limit);
            Console.WriteLine("Initial numbers read from file: " + firstNumber + ", " + secondNumber);
            Console.WriteLine($"Fibonacci series up to {limit}:");
            fib.CalculateFibonacciWithLimit(limit);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Counter of steps read from file: " + limit);
            Console.WriteLine("Initial numbers read from file: " + firstNumber + ", " + secondNumber);
            Console.WriteLine($"Fibonacci series with {limit} steps:");
            fib.CalculateFibonacciWithSteps(limit);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    
}
