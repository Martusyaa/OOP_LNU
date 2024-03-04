using fibonacci_one_two;
using System;
using System.Collections.Generic;
using System.IO;

namespace fibonacci_one_two
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersReader numbersReader = new NumbersReader();
            string filePath = "File.txt";

            List<int> numbers = numbersReader.ReadNumbersFromFile(filePath);

            Fib fibonacci = new Fib(numbers);
            //limit is 108
            Console.WriteLine("With limit:");
            fibonacci.Calculatewithlimit();
            //step is 10
            Console.WriteLine("With step");
            fibonacci.Calculatewithsteps();
        }
    }

}
