using System;
using System.IO;


public interface IMatrixOperations
{
    int[,] Add(int[,] matrixA, int[,] matrixB);
    int[,] Subtract(int[,] matrixA, int[,] matrixB);
    int[,] Multiply(int[,] matrixA, int[,] matrixB);
}


public class MatrixOperations : IMatrixOperations
{
    public int[,] Add(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return result;
    }

    public int[,] Subtract(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }

        return result;
    }

    public int[,] Multiply(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);
        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }
}


public interface IMatrixPrinter
{
    void PrintMatrix(int[,] matrix);
}


public class MatrixPrinter : IMatrixPrinter
{
    public void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

public class FileMatrixProvider
{
    public int[,] ReadMatrix(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        int rows = lines.Length;
        int cols = lines[0].Split(' ').Length;
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string[] values = lines[i].Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(values[j]);
            }
        }

        return matrix;
    }

    public void WriteMatrix(string filePath, int[,] matrix)
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sw.Write($"{matrix[i, j]} ");
                }
                sw.WriteLine();
            }
        }
    }
}


public class MatrixCalculator
{
    private readonly IMatrixOperations _matrixOperations;
    private readonly IMatrixPrinter _matrixPrinter;
    private readonly FileMatrixProvider _fileMatrixProvider;

    public MatrixCalculator(IMatrixOperations matrixOperations, IMatrixPrinter matrixPrinter, FileMatrixProvider fileMatrixProvider)
    {
        _matrixOperations = matrixOperations;
        _matrixPrinter = matrixPrinter;
        _fileMatrixProvider = fileMatrixProvider;
    }

    public void PerformOperations(string inputFilePathA, string inputFilePathB, string outputFilePathSum, string outputFilePathProduct, string outputFilePathDifference)
    {
        int[,] matrixA = _fileMatrixProvider.ReadMatrix(inputFilePathA);
        int[,] matrixB = _fileMatrixProvider.ReadMatrix(inputFilePathB);

        int[,] sumResult = _matrixOperations.Add(matrixA, matrixB);
        _fileMatrixProvider.WriteMatrix(outputFilePathSum, sumResult);

        int[,] productResult = _matrixOperations.Multiply(matrixA, matrixB);
        _fileMatrixProvider.WriteMatrix(outputFilePathProduct, productResult);

        int[,] differenceResult = _matrixOperations.Subtract(matrixA, matrixB);
        _fileMatrixProvider.WriteMatrix(outputFilePathDifference, differenceResult);
    }


}

class Program
{
    static void Main()
    {
        IMatrixOperations matrixOperations = new MatrixOperations();
        IMatrixPrinter matrixPrinter = new MatrixPrinter();
        FileMatrixProvider fileMatrixProvider = new FileMatrixProvider();
        MatrixCalculator calculator = new MatrixCalculator(matrixOperations, matrixPrinter, fileMatrixProvider);

        string inputFilePathA = "C:\\Users\\User\\source\\repos\\Matrix_Maksymiv_Roman\\Matrix_Maksymiv_Roman\\matrixA.txt";
        string inputFilePathB = "C:\\Users\\User\\source\\repos\\Matrix_Maksymiv_Roman\\Matrix_Maksymiv_Roman\\matrixB.txt";
        string outputFilePathSum = "C:\\Users\\User\\source\\repos\\Matrix_Maksymiv_Roman\\Matrix_Maksymiv_Roman\\sumResult.txt";
        string outputFilePathProduct = "C:\\Users\\User\\source\\repos\\Matrix_Maksymiv_Roman\\Matrix_Maksymiv_Roman\\productResult.txt";
        string outputFilePathDifference = "C:\\Users\\User\\source\\repos\\Matrix_Maksymiv_Roman\\Matrix_Maksymiv_Roman\\differenceResult.txt";

        calculator.PerformOperations(inputFilePathA, inputFilePathB, outputFilePathSum, outputFilePathProduct, outputFilePathDifference);
    }
}
