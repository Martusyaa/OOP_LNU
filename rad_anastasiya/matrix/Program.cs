using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace matrixx
{
    class Program
    {
        const string DifferentDimension = "Dimensions are different";
        const string IncompatibleDimension = "Incompatible dimensions for matrix multiplication";
        const string DivisionByZero = "Division by zero is not allowed";

        static List<List<double>> ReadMatrix(string fileName)
        {
            var matrix = new List<List<double>>();
            using (StreamReader file = new StreamReader(fileName))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    List<double> row = ParseRow(line);
                    matrix.Add(row);
                }
            }

            return matrix;
        }

        static List<double> ParseRow(string row)
        {
            return row.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(num => double.Parse(num))
                .ToList();
        }

        static void WriteMatrix(List<List<double>> matrix, string fileName)
        {
            using (StreamWriter file = new StreamWriter(fileName))
            {
                foreach (var row in matrix)
                {
                    file.WriteLine(string.Join(" ", row));
                }
            }
        }

        static void MatrixDimensionCheck(List<List<double>> first, List<List<double>> second)
        {
            if (first.Count != second.Count || first[0].Count != second[0].Count)
                throw new Exception(DifferentDimension);
        }

        static List<List<double>> AddMatrices(List<List<double>> first, List<List<double>> second)
        {
            MatrixDimensionCheck(first, second);

            var resultMatrix = new List<List<double>>();
            for (int i = 0; i < first.Count; i++)
            {
                resultMatrix.Add(new List<double>());
                for (int j = 0; j < first[0].Count; j++)
                {
                    resultMatrix[i].Add(first[i][j] + second[i][j]);
                }
            }

            return resultMatrix;
        }

        static List<List<double>> SubtractMatrices(List<List<double>> first, List<List<double>> second)
        {
            MatrixDimensionCheck(first, second);

            var resultMatrix = new List<List<double>>();
            for (int i = 0; i < first.Count; i++)
            {
                resultMatrix.Add(new List<double>());
                for (int j = 0; j < first[0].Count; j++)
                {
                    resultMatrix[i].Add(first[i][j] - second[i][j]);
                }
            }

            return resultMatrix;
        }

        static List<List<double>> MultiplyMatrices(List<List<double>> first, List<List<double>> second)
        {
            if (first[0].Count != second.Count)
                throw new Exception(IncompatibleDimension);

            var resultMatrix = new List<List<double>>();
            for (int i = 0; i < first.Count; i++)
            {
                resultMatrix.Add(new List<double>());
                for (int j = 0; j < second[0].Count; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < second.Count; k++)
                    {
                        sum += first[i][k] * second[k][j];
                    }

                    resultMatrix[i].Add(sum);
                }
            }

            return resultMatrix;
        }

        static List<List<double>> DivideMatrix(List<List<double>> first, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException(DivisionByZero);

            var resultMatrix = new List<List<double>>();
            for (int i = 0; i < first.Count; i++)
            {
                resultMatrix.Add(new List<double>());
                for (int j = 0; j < first[0].Count; j++)
                 {
                     resultMatrix[i].Add(first[i][j] / divisor);
                 }
             }
 
             return resultMatrix;
         }
 
         static void Main()
         {
             try
             {
                 var first = ReadMatrix("D:\\nanaka\\унік_прога\\matrixx\\matrixx\\first_matrix.txt");
                 var second = ReadMatrix("D:\\nanaka\\унік_прога\\matrixx\\matrixx\\second_matrix.txt");
 
                 string[] operations = { "+", "-", "*", "/" };
 
                 using (StreamWriter resultFile =
                        new StreamWriter("D:\\nanaka\\унік_прога\\matrixx\\matrixx\\result.txt"))
                 {
                     foreach (var operation in operations)
                     {
                         resultFile.WriteLine($"Operation: {operation}");
 
                         List<List<double>> resultMatrix = new List<List<double>>();
                         if (operation == "+")
                             resultMatrix = AddMatrices(first, second);
                         else if (operation == "-")
                             resultMatrix = SubtractMatrices(first, second);
                         else if (operation == "*")
                             resultMatrix = MultiplyMatrices(first, second);
                         else if (operation == "/")
                         {
                             // Divide by 2, update divisor if needed
                             double divisor = 2;
                             resultMatrix = DivideMatrix(first, divisor);
                         }
 
                         resultFile.WriteLine("Result:");
                         foreach (var row in resultMatrix)
                         {
                             resultFile.WriteLine(string.Join(" ", row));
                         }
 
                         resultFile.WriteLine();
                     }
                 }
             }
             catch (Exception e)
             {
                 using (StreamWriter resultFile =
                        new StreamWriter("D:\\nanaka\\унік_прога\\matrixx\\matrixx\\result.txt"))
                 {
                     resultFile.WriteLine(e.Message);
                 }
             }
         }
     }
 }