using System;


namespace Matrix
{
    public class Calculator
    {
        public static Matrix Add(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                Console.WriteLine("Matrix must have the same size");
            }

            double[,] resultData = new double[matrix1.rows, matrix1.cols];

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.cols; j++)
                {
                    resultData[i, j] = matrix1.data[i, j] + matrix2.data[i, j];
                }
            }

            return new Matrix(resultData);
        }

        public static Matrix Substact(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                Console.WriteLine("Matrix must have the same size");
            }
            double[,] resultData = new double[matrix1.rows, matrix1.cols];

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix2.rows; j++)
                {
                    resultData[i, j] = matrix1.data[i, j] - matrix2.data[i, j];
                }
            }

            return new Matrix(resultData);
        }

        public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                Console.WriteLine("Matrix must have the same size");
            }
            double[,] resultData = new double[matrix1.rows, matrix1.cols];

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix2.rows; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < matrix1.cols; k++)
                    {
                        sum += matrix1.data[i, k] * matrix2.data[k, j];
                    }
                    resultData[i, j] = sum;
                }
            }
            return new Matrix(resultData);
        }

        public static Matrix InverseMatrix(Matrix matrix)
        {
            double[,] augmentedMatrix = new double[matrix.rows, 2 * matrix.cols];

            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    augmentedMatrix[i, j] = matrix.data[i, j];
                }
                augmentedMatrix[i, matrix.rows + i] = 1;
            }

            for (int i = 0; i < matrix.rows; i++)
            {
                double pivot = augmentedMatrix[i, i];
                for (int j = 0; j < 2 * matrix.cols; j++)
                {
                    augmentedMatrix[i, j] /= pivot;
                }

                for (int k = 0; k < matrix.rows; k++)
                {
                    if (k == i)
                    {
                        continue;
                    }
                    double factor = augmentedMatrix[k, i];
                    for (int j = 0; j < 2 * matrix.cols; j++)
                    {
                        augmentedMatrix[k, j] -= factor * augmentedMatrix[i, j];
                    }
                }
            }

            double[,] inverse = new double[matrix.rows, matrix.cols];
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    inverse[i, j] = augmentedMatrix[i, matrix.cols + j];
                }
            }

            return new Matrix(inverse);
        }
        public static Matrix Divide(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                Console.WriteLine("Matrix must have the same size");
            }
            double[,] resultData = new double[matrix1.rows, matrix1.cols];

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix2.rows; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < matrix1.cols; k++)
                    {
                        sum += matrix1.data[i, k] * matrix2.data[k, j];
                    }
                    resultData[i, j] = sum;
                }
            }
            return new Matrix(resultData);
        }
    }
}
