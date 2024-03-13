using System;

class Program
{
    static void Main()
    {
        string file_one = "matrix1.txt";
        string file_second = "matrix2.txt";

        Console.WriteLine("Matrix 1:");
        int[][] matrix_one = MatrixMethods.Read_File(file_one);
        MatrixMethods.PrintMatrix(matrix_one);

        Console.WriteLine("\nMatrix 2:");
        int[][] matrix2_second = MatrixMethods.Read_File(file_second);
        MatrixMethods.PrintMatrix(matrix2_second);

        try
        {
            Console.WriteLine("\nMatrix addition:");
            int[][] resultMatrix_addition = MatrixMethods.AddMatrices(matrix_one, matrix2_second);
            MatrixMethods.PrintMatrix(resultMatrix_addition);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Matrix addition failed: " + ex.Message);
        }

        try
        {
            Console.WriteLine("\nMatrix difference:");
            int[][] resultMatrix_difference = MatrixMethods.DifferenceMatrices(matrix_one, matrix2_second);
            MatrixMethods.PrintMatrix(resultMatrix_difference);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Matrix difference failed: " + ex.Message);
        }

        try
        {
            Console.WriteLine("\nMatrix multiplication:");
            int[][] resultMatrix_multiply = MatrixMethods.MultiplyMatrices(matrix_one, matrix2_second);
            MatrixMethods.PrintMatrix(resultMatrix_multiply);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Matrix multiplication failed: " + ex.Message);
        }
    }
}