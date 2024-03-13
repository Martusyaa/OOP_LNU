using System;
using System.IO;

public static class MatrixOperations
{
    public static Matrix ReadMatrixFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        int rows = lines.Length;
        int columns = lines[0].Split(' ').Length;
        int[,] data = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] rowValues = lines[i].Split(' ');
            for (int j = 0; j < columns; j++)
            {
                data[i, j] = int.Parse(rowValues[j]);
            }
        }
        return new Matrix(data);
    }

    public static void WriteMatrixToFile(string fileName, Matrix matrix)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    writer.Write(matrix[i, j] + " ");
                }
                writer.WriteLine();
            }
        }
    }
}