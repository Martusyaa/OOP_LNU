public class Matrix
{
    private List<List<int>> matrixFirst;
    public Matrix(List<List<int>> first)
    {
        matrixFirst = first;
    }

    public List<List<int>> AddMatrix(Matrix matrixSecond)
    {
        List<List<int>> addMatrix = new List<List<int>>();

        for (int i = 0; i < matrixFirst.Count; i++)
        {
            List<int> add = new List<int>();
            for (int j = 0; j < matrixFirst[i].Count; j++)
            {
                add.Add(matrixFirst[i][j] + matrixSecond.getMatrix()[i][j]);
            }
            addMatrix.Add(add);
        }

        return addMatrix;
    }

    private List<List<int>> getMatrix()
    {
        return this.matrixFirst;
    }

    public List<List<int>> SubMatrix(Matrix matrixSecond)
    {
        List<List<int>> subMatrix = new List<List<int>>();

        for (int i = 0; i < matrixFirst.Count; i++)
        {
            List<int> sub = new List<int>();
            for (int j = 0; j < matrixFirst[i].Count; j++)
            {
                sub.Add(matrixFirst[i][j] - matrixSecond.getMatrix()[i][j]);
            }
            subMatrix.Add(sub);
        }

        return subMatrix;
    }
    
    public List<List<int>> MulMatrix(Matrix matrixSecond)
    {
        List<List<int>> mulMatrix = new List<List<int>>();

        for (int i = 0; i < matrixFirst.Count; i++)
        {
            List<int> mul = new List<int>();
            for (int j = 0; j < matrixSecond.getMatrix()[0].Count; j++)
            {
                int sum = 0;
                for (int k = 0; k < matrixFirst[0].Count; k++)
                {
                    sum += matrixFirst[i][k] * matrixSecond.getMatrix()[k][j];
                }
                mul.Add(sum);
            }
            mulMatrix.Add(mul);
        }

        return mulMatrix;
    }
    
    public void PrintMatrix(List<List<int>> matrix)
    {
        foreach (var row in matrix)
        {
            foreach (var element in row)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
    public void WriteMatrixToFile(List<List<int>> matrix, string fileName, char operation)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine($"{operation}");
            foreach (var row in matrix)
            {
                writer.WriteLine($"{string.Join(" ", row)}");

            }
            writer.WriteLine(); 
        }
    }
}