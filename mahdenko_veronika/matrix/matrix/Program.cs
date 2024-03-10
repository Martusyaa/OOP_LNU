using System;
using System.IO;

namespace MatrixAction
{
    class Program
    {
        static void Main()
        {
            try
            {
                Matrix FirstMatrix = Matrix.ReadFromFile("FirstMatrix.txt");
                Matrix SecondMatrix = Matrix.ReadFromFile("SecondMatrix.txt");

                Console.WriteLine("First matrix:");
                FirstMatrix.Print();

                Console.WriteLine("Second matrix:");
                SecondMatrix.Print();

                try
                {
                    Matrix sumMatrix = Matrix.Add(FirstMatrix, SecondMatrix);
                    Console.WriteLine("\nAdd matrix:");
                    sumMatrix.Print();

                    using (StreamWriter writer = new StreamWriter("Result.txt", false))
                    {
                        writer.WriteLine("\nAdd matrix:");
                        sumMatrix.WriteToFile(writer);
                    }
                }
                catch (Exception addException)
                {
                    Console.WriteLine($"Error during addition: {addException.Message}");
                }

                try
                {
                    Matrix differenceMatrix = Matrix.Difference(FirstMatrix, SecondMatrix);
                    Console.WriteLine("\nDifference matrix:");
                    differenceMatrix.Print();

                    using (StreamWriter writer = new StreamWriter("Result.txt", true))
                    {
                        writer.WriteLine("\nDifference matrix:");
                        differenceMatrix.WriteToFile(writer);
                    }
                }
                catch (Exception differenceException)
                {
                    Console.WriteLine($"Error during difference: {differenceException.Message}");
                }

                try
                {
                    Matrix multiplyMatrix = Matrix.Multiply(FirstMatrix, SecondMatrix);
                    Console.WriteLine("\nMultiply matrix:");
                    multiplyMatrix.Print();

                    using (StreamWriter writer = new StreamWriter("Result.txt", true))
                    {
                        writer.WriteLine("\nMultiply matrix:");
                        multiplyMatrix.WriteToFile(writer);
                    }
                }
                catch (Exception multiplyException)
                {
                    Console.WriteLine($"Error during multiplication: {multiplyException.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
