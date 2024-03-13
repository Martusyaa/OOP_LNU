using System;

class Program
{
    static void Main()
    {
        Matrix matrixA = MatrixOperations.ReadMatrixFromFile("../../../matrixA.txt");
        Matrix matrixB = MatrixOperations.ReadMatrixFromFile("../../../matrixB.txt");

        try
        {
            Matrix additionResult = matrixA + matrixB;
            Matrix subtractionResult = matrixA - matrixB;
            Matrix multiplicationResult = matrixA * matrixB;

            MatrixOperations.WriteMatrixToFile("../../../additionResult.txt", additionResult);
            MatrixOperations.WriteMatrixToFile("../../../subtractionResult.txt", subtractionResult);
            MatrixOperations.WriteMatrixToFile("../../../multiplicationResult.txt", multiplicationResult);

            Console.WriteLine("Результати записані у файлах");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}