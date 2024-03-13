using System;
using System.Collections.Generic;
using System.IO;

namespace MatrixAction
{
    public class Matrix
    {
        public List<List<int>> Data { get; set; }

        public Matrix(List<List<int>> data)
        {
            Data = data;
        }

        public static Matrix ReadFromFile(string filename)
        {
            List<List<int>> matrixData = new List<List<int>>();

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    List<int> row = new List<int>();

                    foreach (string value in line.Split(','))
                    {
                        row.Add(int.Parse(value.Trim()));
                    }

                    matrixData.Add(row);
                }
            }

            return new Matrix(matrixData);
        }

        public void Print()
        {
            foreach (var row in Data)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        public static Matrix Add(params Matrix[] matrix)
        {

            int rows = matrix[0].Data.Count;
            int cols = matrix[0].Data[0].Count;

            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i].Data.Count != rows || matrix[i].Data[0].Count != cols)
                {
                    throw new ArgumentException("Matrices must be the same size for add.");
                }
            }

            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < cols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix.Length; k++)
                    {
                        sum += matrix[k].Data[i][j];
                    }
                    row.Add(sum);
                }
                result.Add(row);
            }

            return new Matrix(result);
        }

        public static Matrix Difference(params Matrix[] matrix)
        {

            int rows = matrix[0].Data.Count;
            int cols = matrix[0].Data[0].Count;

            for (int i = 1; i < matrix.Length; i++)
            {
                if (matrix[i].Data.Count != rows || matrix[i].Data[0].Count != cols)
                {
                    throw new ArgumentException("Matrices must be the same size for difference.");
                }
            }

            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < cols; j++)
                {
                    int diff = matrix[0].Data[i][j];
                    for (int k = 1; k < matrix.Length; k++)
                    {
                        diff -= matrix[k].Data[i][j];
                    }
                    row.Add(diff);
                }
                result.Add(row);
            }

            return new Matrix(result);
        }

        public static Matrix Multiply(params Matrix[] matrix)
        {

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                if (matrix[i].Data[0].Count != matrix[i + 1].Data.Count)
                {
                    throw new ArgumentException("The number columns of one matrix is not equal to number rows of the next matrix.");
                }
            }

            List<List<int>> result = new List<List<int>>();
            Matrix intermediateResult = matrix[0];

            for (int k = 1; k < matrix.Length; k++)
            {
                int rowsResult = intermediateResult.Data.Count;
                int colsResult = matrix[k].Data[0].Count;

                result.Clear();
                for (int i = 0; i < rowsResult; i++)
                {
                    List<int> row = new List<int>();
                    for (int j = 0; j < colsResult; j++)
                    {
                        int product = 0;
                        for (int l = 0; l < intermediateResult.Data[0].Count; l++)
                        {
                            product += intermediateResult.Data[i][l] * matrix[k].Data[l][j];
                        }
                        row.Add(product);
                    }
                    result.Add(row);
                }

                intermediateResult = new Matrix(result);
            }

            return intermediateResult;
        }

        public void WriteToFile(StreamWriter writer)
        {
            foreach (var row in Data)
            {
                writer.WriteLine(string.Join(",", row));
            }
        }
    }
}