using System;
using System.IO;

class MatrixOperations
{
    static void Main()
    {
        int[,] matrixA;
        int[,] matrixB;

        try
        {
            using (StreamReader sr = new StreamReader("MatrixA.txt"))
            {
                matrixA = ReadMatrix(sr);
            }

            using (StreamReader sr = new StreamReader("MatrixB.txt"))
            {
                matrixB = ReadMatrix(sr);
            }

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);

            int[,] resultAddition = new int[rowsA, colsA];
            int[,] resultSubtraction = new int[rowsA, colsA];
            int[,] resultMultiplication = new int[rowsA, colsB];


            if (rowsA != matrixB.GetLength(0) || colsA != colsB)
            {
                throw new ArgumentException("Матриці мають мати однакові розміри для додавання або віднімання, і кількість стовбців першої матриці повинна дорівнювати кількості рядків другої матриці для множення");
            }

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    resultAddition[i, j] = matrixA[i, j] + matrixB[i, j];
                    resultSubtraction[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }


            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                throw new Exception("множення неможливе! Кількість стовбців першої матриці не дорівнює кількості рядків другої матриці.");
            }

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMultiplication[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            Console.WriteLine("Матриця A:");
            PrintMatrix(matrixA);

            Console.WriteLine("\nМатриця B:");
            PrintMatrix(matrixB);

            Console.WriteLine("\nДодавання матриць:");
            PrintMatrix(resultAddition);

            Console.WriteLine("\nВіднімання матриць:");
            PrintMatrix(resultSubtraction);

            Console.WriteLine("\nМноження матриць:");
            PrintMatrix(resultMultiplication);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Не вдалося знайти один або обидва файли матриць.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Сталася помилка: " + e.Message);
        }
    }

    static int[,] ReadMatrix(StreamReader sr)
    {
        string line;
        string[] tokens;
        int[,] matrix;
        int rows = 0;
        int cols = 0;

        while ((line = sr.ReadLine()) != null)
        {
            tokens = line.Trim().Split(' ');
            if (cols == 0)
            {
                cols = tokens.Length;
            }
            else if (cols != tokens.Length)
            {
                throw new ArgumentException("Матриця має бути прямокутною");
            }
            rows++;
        }

        matrix = new int[rows, cols];

        sr.BaseStream.Seek(0, SeekOrigin.Begin);

        int i = 0;
        while ((line = sr.ReadLine()) != null)
        {
            tokens = line.Trim().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(tokens[j]);
            }
            i++;
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

