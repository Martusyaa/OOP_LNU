using System;
using System.IO;

public class Matrix
{
    private int[,] data;

    public Matrix(int rows, int cols)
    {
        data = new int[rows, cols];
    }

    public static Matrix ReadFromFile(string filePath)
{
    try
    {
        string[] lines = File.ReadAllLines(filePath);
         if (lines.Length == 0)
            {
                throw new ArgumentException($"The file '{filePath}' is empty.");
            }

        int rows = lines.Length;
        int cols = lines[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Matrix matrix = new Matrix(rows, cols);

        for (int i = 0; i < rows; i++)
        {
            string[] lineData = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (lineData.Length != cols) throw new ArgumentException($"The number of columns is inconsistent at line {i + 1}.");

            for (int j = 0; j < cols; j++)
            {
                try
                {
                    matrix.data[i, j] = int.Parse(lineData[j]);
                }
                catch (FormatException)
                {
                    throw new FormatException($"Unable to parse '{lineData[j]}' as an integer at line {i + 1}, column {j + 1}.");
                }
            }
        }

        return matrix;
    }
    catch (FileNotFoundException)
    {
        throw new FileNotFoundException("The file specified could not be found.", filePath);
    }
}


    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.data.GetLength(0) != b.data.GetLength(0) || a.data.GetLength(1) != b.data.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        Matrix result = new Matrix(a.data.GetLength(0), a.data.GetLength(1));

        for (int i = 0; i < a.data.GetLength(0); i++)
        {
            for (int j = 0; j < a.data.GetLength(1); j++)
            {
                result.data[i, j] = a.data[i, j] + b.data[i, j];
            }
        }

        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.data.GetLength(0) != b.data.GetLength(0) || a.data.GetLength(1) != b.data.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        Matrix result = new Matrix(a.data.GetLength(0), a.data.GetLength(1));

        for (int i = 0; i < a.data.GetLength(0); i++)
        {
            for (int j = 0; j < a.data.GetLength(1); j++)
            {
                result.data[i, j] = a.data[i, j] - b.data[i, j];
            }
        }

        return result;
    }

   public static Matrix operator *(Matrix a, Matrix b)
  {
    if (a.data.GetLength(1) != b.data.GetLength(0))
    {
        throw new ArgumentException("The number of columns in the first matrix must be equal to the number of rows in the second matrix for multiplication.");
    }

    int aRows = a.data.GetLength(0);
    int aCols = a.data.GetLength(1);
    int bCols = b.data.GetLength(1);
    Matrix result = new Matrix(aRows, bCols);

    for (int i = 0; i < aRows; i++)
    {
        for (int j = 0; j < bCols; j++)
        {
            result.data[i, j] = 0;
            for (int k = 0; k < aCols; k++)
            {
                result.data[i, j] += a.data[i, k] * b.data[k, j];
            }
        }
    }

    return result;
}


    public override string ToString()
    {
        string output = "";
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                output += data[i, j] + " ";
            }
            output += "\n";
        }
        return output.TrimEnd();
    }
}

class Program
{
   static void Main(string[] args)
{
    try
    {
        Matrix matrix_a = Matrix.ReadFromFile("matrix_a.txt");
        Matrix matrix_b = Matrix.ReadFromFile("matrix_b.txt");

        Matrix sum = matrix_a + matrix_b;
        Matrix difference = matrix_a - matrix_b;
        Matrix product = matrix_a * matrix_b; 

        Console.WriteLine("Sum:\n" + sum);
        Console.WriteLine("Difference:\n" + difference);
        Console.WriteLine("Product:\n" + product);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("An error occurred during matrix operation: " + ex.Message);
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
}

}
