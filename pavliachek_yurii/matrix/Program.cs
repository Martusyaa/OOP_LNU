using System;
using System.IO;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filename1 = "matrix_one.txt";
                string filename2 = "matrix_two.txt";

                Matrix matrix1 = Matrix.FromFile(filename1);
                Matrix matrix2 = Matrix.FromFile(filename2);

                Console.WriteLine("The first matrix:");
                matrix1.Print();

                Console.WriteLine("\nThe second matrix:");
                matrix2.Print();

                Console.WriteLine("\nSum:");
                Matrix sumMatrix = Calculator.Add(matrix1, matrix2);
                sumMatrix.Print();

                Console.WriteLine("\nSubtract:");
                Matrix subMatrix = Calculator.Substact(matrix1, matrix2);
                subMatrix.Print();

                Console.WriteLine("\nMultiply:");
                Matrix mulMatrix = Calculator.Multiply(matrix1, matrix2);
                mulMatrix.Print();

                Console.WriteLine("\nInverse Matrix:");
                Matrix inverseMatrix = Calculator.InverseMatrix(matrix2);
                if (inverseMatrix != null)
                    inverseMatrix.Print();

                Console.WriteLine("\nDivide:");
                Matrix divMatrix = Calculator.Divide(matrix1, inverseMatrix);
                if (divMatrix != null)
                    divMatrix.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
