using System;
using System.IO;
using Matrix;
using Matrix.Operations;


namespace Program
{
    class Init
    {
        readonly static string firstFilepath = @"F:\C#\Matrix\Matrix\FirstMatrix.txt"; 
        readonly static string secondFilepath = @"F:\C#\Matrix\Matrix\SecondMatrix.txt";
        private static void PrintMatrix(MatrixContainer matrix)
        {
            for (int i = 0; i < matrix.CountRows; ++i)
            {
                for (int j = 0; j < matrix.CountCols; ++j)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        private static void TestMatrixAdd()
        {
            MatrixContainer firstMatrix = ReadMatrixFromFile(firstFilepath);
            MatrixContainer secondMatrix = ReadMatrixFromFile(secondFilepath);

            MatrixContainer sumMatrix = MatrixOperations.Add(firstMatrix, secondMatrix);
            ////MatrixContainer sumMatrix = firstMatrix + secondMatrix;

            Console.WriteLine("First matrix:");
            PrintMatrix(firstMatrix);
            Console.WriteLine("\nSecond matrix");
            PrintMatrix(secondMatrix);
            Console.WriteLine("\nSum matrix:");
            PrintMatrix(sumMatrix);
            Console.WriteLine();
        }

        private static void TestMatrixSubtract()
        {

            MatrixContainer firstMatrix = ReadMatrixFromFile(firstFilepath);
            MatrixContainer secondMatrix = ReadMatrixFromFile(secondFilepath);

            MatrixContainer subtractMatrix = MatrixOperations.Subtract(firstMatrix, secondMatrix);
            ////MatrixContainer sumMatrix = firstMatrix - secondMatrix;

            Console.WriteLine("First matrix:");
            PrintMatrix(firstMatrix);
            Console.WriteLine("\nSecond matrix:");
            PrintMatrix(secondMatrix);
            Console.WriteLine("\nSubtracted matrix:");
            PrintMatrix(subtractMatrix);
            Console.WriteLine();
        }

        private static void TestMatrixMultiply()
        {

            MatrixContainer firstMatrix = ReadMatrixFromFile(firstFilepath);
            MatrixContainer secondMatrix = ReadMatrixFromFile(secondFilepath);

            MatrixContainer multiplyOfMatrix = MatrixOperations.Multiply(firstMatrix, secondMatrix);
            Console.WriteLine("First matrix:");
            PrintMatrix(firstMatrix);
            Console.WriteLine("\nSecond matrix:");
            PrintMatrix(secondMatrix);
            Console.WriteLine("\nMultiplied matrix:");
            PrintMatrix(multiplyOfMatrix);
            Console.WriteLine();

        }

        private static void Main(string[] args)
        {
            TestMatrixAdd();
            TestMatrixSubtract();
            TestMatrixMultiply();

            Console.ReadKey();

        }

        private static MatrixContainer ReadMatrixFromFile(string filepath)
        {
            MatrixContainer retMatrix = null;

            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("File not found");
            }

            try 
            { 
                using (StreamReader file = new StreamReader(filepath))
                {
                    double[,] matrixArr;
                    string? line = file.ReadLine();
                    int row = Int32.Parse(line);

                    line = file.ReadLine();
                    int column = Int32.Parse(line);

                    int countRow = 0;

                    matrixArr = new double[row, column];

                    while ((line = file.ReadLine()) != null)
                    {
                        string[] values = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                        if (values.Length != column || countRow == row)
                        {
                            throw new Exception();
                        }

                        for (int countColumn = 0; countColumn < values.Length; ++countColumn)
                        {
                            matrixArr[countRow, countColumn] = Double.Parse(values[countColumn]);
                        }

                        ++countRow;
                    }

                    retMatrix = new MatrixContainer(matrixArr);
                }
            }

            catch
            {
                Console.WriteLine("Invalid file format. Exiting");
                return null;
            }

            return retMatrix;
        }
    }
}
