using System;
using System.IO;

class MatrixOperations
{
    static void Main()
    {
        try
        {
            int[,] matrix1 = Matrixes.ReadMatrixFromFile("C:\\Users\\User\\source\\repos\\Matrix\\Matrix\\matrix1.txt");
            int[,] matrix2 = Matrixes.ReadMatrixFromFile("C:\\Users\\User\\source\\repos\\Matrix\\Matrix\\matrix2.txt");

            int[,] sumMatrix = Matrixes.AddMatrices(matrix1, matrix2);
            Matrixes.WriteMatrixToFile("sumMatrix.txt", sumMatrix);

            int[,] differenceMatrix = Matrixes.SubtractMatrices(matrix1, matrix2);
            Matrixes.WriteMatrixToFile("differenceMatrix.txt", differenceMatrix);

            int[,] productMatrix = Matrixes.MultiplyMatrices(matrix1, matrix2);
            Matrixes.WriteMatrixToFile("productMatrix.txt", productMatrix);

            Console.WriteLine("Matrix operations performed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
    

    
