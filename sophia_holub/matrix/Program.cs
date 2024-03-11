using System;
using System.IO;

class Program
{
    static int[][] ReadMatrixFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int[][] matrix = new int[lines.Length][];
        for (int i = 0; i < lines.Length; i++)
        {
            string[] elements = lines[i].Split(' ');
            matrix[i] = new int[elements.Length];
            for (int j = 0; j < elements.Length; j++)
            {
                int number;
                if (int.TryParse(elements[j], out number))
                {
                    matrix[i][j] = number;
                }
                else
                {
                    throw new FormatException("error in row " + (i + 1) + " column " + (j + 1));
                }
            }
        }
        return matrix;
    }

    static int[][] AddMatrices(int[][] matrix1, int[][] matrix2)
    {
        int[][] result = new int[matrix1.Length][];
        for (int i = 0; i < matrix1.Length; i++)
        {
            result[i] = new int[matrix1[i].Length];
            for (int j = 0; j < matrix1[i].Length; j++)
            {
                result[i][j] = matrix1[i][j] + matrix2[i][j];
            }
        }
        return result;
    }

    static int[][] SubtractMatrices(int[][] matrix1, int[][] matrix2)
    {
        int[][] result = new int[matrix1.Length][];
        for (int i = 0; i < matrix1.Length; i++)
        {
            result[i] = new int[matrix1[i].Length];
            for (int j = 0; j < matrix1[i].Length; j++)
            {
                result[i][j] = matrix1[i][j] - matrix2[i][j];
            }
        }
        return result;
    }

    static int[][] MultiplyMatrices(int[][] matrix1, int[][] matrix2)
    {
        int[][] result = new int[matrix1.Length][];
        for (int i = 0; i < matrix1.Length; i++)
        {
            result[i] = new int[matrix2[0].Length];
            for (int j = 0; j < matrix2[0].Length; j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix2.Length; k++)
                {
                    sum += matrix1[i][k] * matrix2[k][j];
                }
                result[i][j] = sum;
            }
        }
        return result;
    }

    static void PrintMatrix(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        string matrix1File = @"C:\Sofia\prog and crypto\додВідмнож матриць\Матриці\Матриці\matrix1.txt";
        string matrix2File = @"C:\Sofia\prog and crypto\додВідмнож матриць\Матриці\Матриці\matrix2.txt";

        try
        {
            int[][] matrix1 = ReadMatrixFromFile(matrix1File);
            int[][] matrix2 = ReadMatrixFromFile(matrix2File);

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);

            Console.WriteLine("Matrix 2:");
            PrintMatrix(matrix2);

            Console.WriteLine("Addition:");
            int[][] resultAddition = AddMatrices(matrix1, matrix2);
            PrintMatrix(resultAddition);

            Console.WriteLine("Substaction:");
            int[][] resultSubtraction = SubtractMatrices(matrix1, matrix2);
            PrintMatrix(resultSubtraction);

            Console.WriteLine("Multiplication:");
            int[][] resultMultiplication = MultiplyMatrices(matrix1, matrix2);
            PrintMatrix(resultMultiplication);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
