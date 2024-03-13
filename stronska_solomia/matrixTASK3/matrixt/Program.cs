
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            int[,] matrix1 = ReadMatrixFromFile("input1.txt");
            int[,] matrix2 = ReadMatrixFromFile("input2.txt");

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);
            Console.WriteLine();

            Console.WriteLine("Matrix 2:");
            PrintMatrix(matrix2);
            Console.WriteLine();

            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                Console.WriteLine("Matrices have different sizes.");
                return;
            }

            int[,] sumMatrix = AddMatrices(matrix1, matrix2);
            int[,] differenceMatrix = SubtractMatrices(matrix1, matrix2);

            Console.WriteLine("Sum of matrices:");
            PrintMatrix(sumMatrix);
            Console.WriteLine();

            Console.WriteLine("Difference of matrices:");
            PrintMatrix(differenceMatrix);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static int[,] ReadMatrixFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int rows = lines.Length;
        int columns = lines[0].Split(' ').Length;
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] values = lines[i].Split(' ');
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(values[j]);
            }
        }

        return matrix;
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
