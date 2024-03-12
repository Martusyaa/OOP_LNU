using System;
using System.Collections.Generic;
using System.IO;
using static MatrixProgram.InputRead;
using static MatrixProgram.Matrix;

namespace MatrixProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pathOne = "./matrixOne.txt";
            const string pathTwo = "./matrixTwo.txt";
            List<List<double>> inputOne = InputRead.ReadMatrixFromFile(pathOne);
            List<List<double>> inputTwo = InputRead.ReadMatrixFromFile(pathTwo);
            Matrix matrixOne = new Matrix(inputOne);
            Matrix matrixTwo = new Matrix(inputTwo);

            System.Console.WriteLine(matrixOne + matrixTwo);
            System.Console.WriteLine(matrixOne - matrixTwo);
            System.Console.WriteLine(matrixOne * matrixTwo);
        }
    }
}
