using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<List<int>> matrixFirst = new List<List<int>>();
        List<List<int>> matrixSecond = new List<List<int>>();

        try
        {
            using (StreamReader matrixFirstFile = File.OpenText("MatrixFirst.txt"))
            {
                string numbersLine;
                while ((numbersLine = matrixFirstFile.ReadLine()) != null)
                {
                    List<int> first = numbersLine.Split(' ')
                        .Where(s => !string.IsNullOrWhiteSpace(s))
                        .Select(int.Parse)
                        .ToList();
                    matrixFirst.Add(first);
                }
            }

            using (StreamReader matrixSecondFile = File.OpenText("MatrixSecond.txt"))
            {
                string numbersLine;
                while ((numbersLine = matrixSecondFile.ReadLine()) != null)
                {
                    List<int> second = numbersLine.Split(' ')
                        .Where(s => !string.IsNullOrWhiteSpace(s))
                        .Select(int.Parse)
                        .ToList();
                    matrixSecond.Add(second);
                }
            }

            Matrix obj = new Matrix(matrixFirst);

            Console.WriteLine("First matrix:");
            obj.PrintMatrix(matrixFirst);
            Console.WriteLine("Second matrix:");
            obj.PrintMatrix(matrixSecond);
            if (matrixFirst.Count == matrixSecond.Count && matrixFirst[0].Count == matrixSecond[0].Count)
            {
                List<List<int>> addMatrix = obj.AddMatrix(new Matrix(matrixSecond));
                List<List<int>> subMatrix = obj.SubMatrix(new Matrix(matrixSecond));
                Console.WriteLine("Addition matrix:");
                obj.PrintMatrix(addMatrix);
                Console.WriteLine("Subtraction matrix:");
                obj.PrintMatrix(subMatrix);
                
                obj.WriteMatrixToFile(addMatrix, "Result.txt", '+');
                obj.WriteMatrixToFile(subMatrix, "Result.txt", '-');
            }
            if (matrixFirst.Count == matrixSecond[0].Count)
            {
                List<List<int>> mulMatrix = obj.MulMatrix(new Matrix(matrixSecond));
                Console.WriteLine("Multiplication matrix:");
                obj.PrintMatrix(mulMatrix);
                
                obj.WriteMatrixToFile(mulMatrix, "Result.txt", '*');
            }
            else
            {
                Console.WriteLine("Error: Size is different!");
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found: {e.FileName}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}
