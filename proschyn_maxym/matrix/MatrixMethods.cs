using System;
using System.IO;

public class MatrixMethods
{
    public static int[][] Read_File(string file_name)
    {
        string[] lines = File.ReadAllLines(file_name);
        int rows = lines.Length;
        int[][] matrix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            string[] values = lines[i].Split(' ');
            matrix[i] = new int[values.Length];
            for (int j = 0; j < values.Length; j++)
            {
                matrix[i][j] = int.Parse(values[j]);
            }
        }

        return matrix;
    }

    public static void PrintMatrix(int[][] matrix)
    {
        foreach (int[] row in matrix)
        {
            foreach (int value in row)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }

    public static int[][] AddMatrices(int[][] matrix1, int[][] matrix2)
    {
        int rows1 = matrix1.Length;
        int columns1 = matrix1[0].Length;
        int rows2 = matrix2.Length;
        int columns2 = matrix2[0].Length;

        if (rows1 != rows2 || columns1 != columns2)
        {
            throw new ArgumentException("Matrices have different sizes and cannot be added.");
        }

        int[][] result = new int[rows1][];

        for (int i = 0; i < rows1; i++)
        {
            result[i] = new int[columns1];
            for (int j = 0; j < columns1; j++)
            {
                result[i][j] = matrix1[i][j] + matrix2[i][j];
            }
        }

        return result;
    }

    public static int[][] DifferenceMatrices(int[][] matrix1, int[][] matrix2)
    {
        int rows1 = matrix1.Length;
        int columns1 = matrix1[0].Length;
        int rows2 = matrix2.Length;
        int columns2 = matrix2[0].Length;

        if (rows1 != rows2 || columns1 != columns2)
        {
            throw new ArgumentException("Matrices have different sizes and cannot be subtracted.");
        }

        int[][] result = new int[rows1][];

        for (int i = 0; i < rows1; i++)
        {
            result[i] = new int[columns1];
            for (int j = 0; j < columns1; j++)
            {
                result[i][j] = matrix1[i][j] - matrix2[i][j];
            }
        }

        return result;
    }

    public static int[][] MultiplyMatrices(int[][] matrix1, int[][] matrix2)
    {
        int rows1 = matrix1.Length;
        int columns1 = matrix1[0].Length;
        int rows2 = matrix2.Length;
        int columns2 = matrix2[0].Length;

        if (columns1 != rows2)
        {
            throw new ArgumentException("Multiplication is impossible.");
        }

        int[][] result = new int[rows1][];

        for (int i = 0; i < rows1; i++)
        {
            result[i] = new int[columns2];
            for (int j = 0; j < columns2; j++)
            {
                for (int k = 0; k < columns1; k++)
                {
                    result[i][j] += matrix1[i][k] * matrix2[k][j];
                }
            }
        }

        return result;
    }
}