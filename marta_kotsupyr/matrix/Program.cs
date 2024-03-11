using System;
using System.IO;

class MatrixMultiplication {
    static void Main() {
        
        int[,] matrix1 = ReadMatrixFromFile("matrix1.txt");
        int[,] matrix2 = ReadMatrixFromFile("matrix2.txt");

        
        int[,] result = MultiplyMatrices(matrix1, matrix2);

        
        WriteMatrixToFile(result, "result.txt");

        Console.WriteLine("Resultant Matrix has been saved to result.txt");
    }

    static int[,] ReadMatrixFromFile(string filename) {
        string[] lines = File.ReadAllLines(filename);
        int rows = lines.Length;
        int cols = lines[0].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++) {
            string[] elements = lines[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < cols; j++) {
                matrix[i, j] = int.Parse(elements[j]);
            }
        }

        return matrix;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2) {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++) {
            for (int j = 0; j < cols2; j++) {
                for (int k = 0; k < cols1; k++) {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    static void WriteMatrixToFile(int[,] matrix, string filename) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        using (StreamWriter writer = new StreamWriter(filename)) {
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    writer.Write(matrix[i, j] + "\t");
                }
                writer.WriteLine();
            }
        }
    }
}
