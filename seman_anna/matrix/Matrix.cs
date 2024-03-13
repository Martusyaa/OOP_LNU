using System;

public class Matrix
{
    private int[,] data;

    public Matrix(int[,] data)
    {
        this.data = data;
    }

    public int Rows => data.GetLength(0);
    public int Columns => data.GetLength(1);

    public int this[int row, int column]
    {
        get => data[row, column];
        set => data[row, column] = value;
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
            throw new ArgumentException("Матриці різних розмірів");

        int[,] result = new int[a.Rows, a.Columns];

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Columns; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }

        return new Matrix(result);
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
            throw new ArgumentException("Матриці різних розмірів");

        int[,] result = new int[a.Rows, a.Columns];

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < a.Columns; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }

        return new Matrix(result);
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Columns != b.Rows)
            throw new ArgumentException("Неправильна кількість елементів.");

        int[,] result = new int[a.Rows, b.Columns];

        for (int i = 0; i < a.Rows; i++)
        {
            for (int j = 0; j < b.Columns; j++)
            {
                for (int k = 0; k < a.Columns; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return new Matrix(result);
    }
}

