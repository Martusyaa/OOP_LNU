namespace Matrix_mult;

class Program
{
    static void Main()
    {
        MatrixOperations matrixOps = new MatrixOperations();
        
        matrixOps.ReadMatrixFromFile("input.txt");
        
        matrixOps.MultiplyMatrices();
        
        matrixOps.WriteResultToFile("output.txt");

        Console.WriteLine("Операція завершена. Результат записано у файл output.txt");
    }
}

public class MatrixOperations
{
    private List<List<int>> A;
    private List<List<int>> B;
    private List<List<int>> result;

    public MatrixOperations()
    {
        A = new List<List<int>>();
        B = new List<List<int>>();
        result = new List<List<int>>();
    }

    public void ReadMatrixFromFile(string fileName)
    {
        try
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                string? line;
                bool isReadingFirstMatrix = true;

                while ((line = file.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        isReadingFirstMatrix = false;
                        continue;
                    }

                    List<int> row = line.Split().Select(int.Parse).ToList();
                    (isReadingFirstMatrix ? A : B).Add(row);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Файл {fileName} не знайдено.");
        }
    }

    public void MultiplyMatrices()
    {
        if (A.Count == 0 || B.Count == 0)
        {
            Console.WriteLine("Матриці A або B є порожніми.");
            return;
        }

        int rowsA = A.Count;
        int colsA = A[0].Count;
        int rowsB = B.Count;
        int colsB = B[0].Count;

        if (colsA != rowsB)
        {
            Console.WriteLine("Невірні розміри матриць для множення.");
            return;
        }

        result.Clear();

        for (int i = 0; i < rowsA; i++)
        {
            List<int> row = new List<int>();
            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += A[i][k] * B[k][j];
                }
                row.Add(sum);
            }
            result.Add(row);
        }
    }

    public void WriteResultToFile(string fileName)
    {
        try
        {
            using (StreamWriter file = new StreamWriter(fileName))
            {
                foreach (List<int> row in result)
                {
                    file.WriteLine(string.Join(" ", row));
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Помилка запису у файл.");
        }
    }
}