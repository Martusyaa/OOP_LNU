using System;
using System.IO;

namespace Matrix
{
    public class Matrix
    {
        public double[,] data { get; set; }
        public int rows { get; set; }
        public int cols { get; set; }

        public Matrix(double[,] inputData)
        {
            data = inputData;
            rows = inputData.GetLength(0);
            cols = inputData.GetLength(1);
        }

        public static Matrix FromFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            double[,] matrixData = new double[lines.Length, lines[0].Split(' ').Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] elements = lines[i].Split(' ');
                for (int j = 0; j < elements.Length; j++)
                {
                    matrixData[i, j] = double.Parse(elements[j]);
                }
            }

            return new Matrix(matrixData);
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

