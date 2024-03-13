namespace Matrix_add_sub;

class MatrixOperations
{
    private List<List<int>> A;
    private List<List<int>> B;

    public MatrixOperations()
    {
        A = new List<List<int>>();
        B = new List<List<int>>();
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
            Console.WriteLine("File not found.");
        }
    }

    public void PerformMatrixOperations()
    {
        if (A.Count == B.Count && A.Count > 0 && A[0].Count == B[0].Count)
        {
            List<List<int>> addition = new List<List<int>>(
                from i in Enumerable.Range(0, A.Count)
                select new List<int>(
                    from j in Enumerable.Range(0, A[0].Count)
                    select A[i][j] + B[i][j]
                )
            );

            try
            {
                using (StreamWriter outputFile = File.AppendText("output.txt"))
                {
                    WriteMatrixToFile(outputFile, "Перша матриця A", A);
                    WriteMatrixToFile(outputFile, "Друга матриця B", B);
                    WriteMatrixToFile(outputFile, "Сума матриць A і B", addition);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

            List<List<int>> subtraction = new List<List<int>>(
                from i in Enumerable.Range(0, A.Count)
                select new List<int>(
                    from j in Enumerable.Range(0, A[0].Count)
                    select A[i][j] - B[i][j]
                )
            );

            try
            {
                using (StreamWriter outputFile = File.AppendText("output.txt"))
                {
                    WriteMatrixToFile(outputFile, "Різниця матриць A і B", subtraction);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }
        else
        {
            Console.WriteLine("Неможливо виконати додавання та віднімання матриць.");
        }
    }

    private static void WriteMatrixToFile(StreamWriter file, string title, List<List<int>> matrix)
    {
        file.WriteLine($"\n{title}:");
        foreach (var row in matrix)
        {
            file.WriteLine(string.Join(" ", row));
        }
    }
}

class Program
{
    static void Main()
    {
        MatrixOperations matrixOperations = new MatrixOperations();
        matrixOperations.ReadMatrixFromFile("input.txt");
        matrixOperations.PerformMatrixOperations();
    }
}