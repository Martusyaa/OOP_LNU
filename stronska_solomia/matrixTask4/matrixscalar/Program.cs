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

            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                Console.WriteLine("Неможливо виконати множення: кількість стовпців першої матриці не дорівнює кількості рядків другої матриці.");
                return;
            }

            int[,] result = MultiplyMatrices(matrix1, matrix2);

            Console.WriteLine("Результат множення матриць:");
            PrintMatrix(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static int[,] ReadMatrixFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int rows = lines.Length;
        int cols = lines[0].Split(' ').Length;
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = lines[i].Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(rowValues[j]);
            }
        }

        return matrix;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
