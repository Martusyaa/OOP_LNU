using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<List<List<int>>> matrices = new List<List<List<int>>>();

            List<List<int>> matrix1 = readMatrixFromFile("matrix_first.txt");
            List<List<int>> matrix2 = readMatrixFromFile("matrix_second.txt");

            matrices.Add(matrix1);
            matrices.Add(matrix2);

            Matrix matrix = new Matrix(matrices);

            List<List<int>> resultAdd = matrix.addMatrix();
            writeMatrixToFile("Addition: ", resultAdd, "result.txt");

            List<List<int>> resultSubtract = matrix.subMatrices();
            writeMatrixToFile("Subtraction: ", resultSubtract, "result.txt");

            List<List<int>> resultMultiply = matrix.multiplyMatrices();
            writeMatrixToFile("Multiplication: ", resultMultiply, "result.txt");

            Console.WriteLine("Matrices are saved in a file.");
        }

        catch (InvalidOperationException e)
        {
            Console.WriteLine("Invalid operation: " + e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("The 'try catch' is finished.");
        }
    }

    static List<List<int>> readMatrixFromFile(string fileName)
    {
        List<List<int>> matrix = new List<List<int>>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                List<int> row = new List<int>();
                string[] values = line.Split(',');
                foreach (string value in values)
                {
                    row.Add(int.Parse(value));
                }
                matrix.Add(row);
            }
        }

        return matrix;
    }
    static void writeMatrixToFile(string label, List<List<int>> matrix, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine(label);
            foreach (var row in matrix)
            {
                foreach (var item in row)
                {
                    writer.Write(item + " ");
                }
                writer.WriteLine();
            }
            writer.WriteLine();
        }
    }
}
