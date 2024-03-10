using System;

class Matrix
{
    private List<List<List<int>>> matrices;

    public Matrix(List<List<List<int>>> matrices)
    {
        this.matrices = matrices;
    }

    public void dimensionalityOfMatrix()
    {
        int rowCount = matrices[0].Count;
        int colCount = matrices[0][0].Count;

        foreach (var matrix in matrices)
        {
            if (matrix.Count != rowCount || matrix[0].Count != colCount)
            {
                throw new InvalidOperationException("Matrices must have the same dimensions.");
            }
        }
    }


    public List<List<int>> addMatrix()
    {
        dimensionalityOfMatrix();

        int rowCount = matrices[0].Count;
        int colCount = matrices[0][0].Count;

        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < rowCount; i++)
        {
            List<int> newRow = new List<int>();
            for (int j = 0; j < colCount; j++)
            {
                int sum = 0;
                foreach (var matrix in matrices)
                {
                    sum += matrix[i][j];
                }
                newRow.Add(sum);
            }
            result.Add(newRow);
        }
        return result;
    }

    public List<List<int>> subMatrices()
    {
        dimensionalityOfMatrix();

        int rowCount = matrices[0].Count;
        int colCount = matrices[0][0].Count;

        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < rowCount; i++)
        {
            List<int> newRow = new List<int>();
            for (int j = 0; j < colCount; j++)
            {
                int difference = matrices[0][i][j];
                for (int k = 1; k < matrices.Count; k++)
                {
                    difference -= matrices[k][i][j];
                }
                newRow.Add(difference);
            }
            result.Add(newRow);
        }
        return result;
    }

    public List<List<int>> multiplyMatrices()
    {
        if (matrices[0][0].Count != matrices[1].Count)
        {
            throw new InvalidOperationException("Number of columns in the first matrix must be equal to the number of rows in the second matrix for multiplication.");
        }

        int rowCountA = matrices[0].Count;
        int colCountA = matrices[0][0].Count;
        int rowCountB = matrices[1].Count;
        int colCountB = matrices[1][0].Count;

        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < rowCountA; i++)
        {
            List<int> newRow = new List<int>();
            for (int j = 0; j < colCountB; j++)
            {
                newRow.Add(0);
            }
            result.Add(newRow);
        }

        for (int i = 0; i < rowCountA; i++)
        {
            for (int j = 0; j < colCountB; j++)
            {
                for (int k = 0; k < rowCountB; k++)
                {
                    result[i][j] += matrices[0][i][k] * matrices[1][k][j];
                }
            }
        }
        return result;
    }
}
