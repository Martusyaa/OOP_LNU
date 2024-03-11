using System;
using System.IO;

namespace MatrixOperations
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[,] matrixA = ReadMatrix("matrix_first.txt");
                int[,] matrixB = ReadMatrix("matrix_second.txt");

                if (matrixA == null || matrixB == null)
                {
                    Console.WriteLine("Error reading matrices. Exiting.");
                    return;
                }

                MatrixCalculator calculator = new MatrixCalculator();

                int[,] resultAdd = calculator.AddMatrices(matrixA, matrixB);
                WriteMatrix(resultAdd, "result_add.txt");

                int[,] resultSubtract = calculator.SubtractMatrices(matrixA, matrixB);
                WriteMatrix(resultSubtract, "result_subtract.txt");

                int[,] resultMultiply = calculator.MultiplyMatrices(matrixA, matrixB);
                WriteMatrix(resultMultiply, "result_multiply.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static int[,] ReadMatrix(string filename)
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                int rows = lines.Length;
                int cols = lines[0].Split().Length;

                int[,] matrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    string[] values = lines[i].Split();
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = int.Parse(values[j]);
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading matrix from {filename}: {ex.Message}");
                return null;
            }
        }

        static void WriteMatrix(Array matrix, string filename)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filename))
                {
                    int rows = matrix.GetLength(0);
                    int cols = matrix.GetLength(1);

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            file.Write(matrix.GetValue(i, j) + " ");
                        }
                        file.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing matrix to {filename}: {ex.Message}");
            }
        }
    }
}
