using System;
using System.Collections.Generic;
using System.IO;

namespace MatrixProgram
{
    static class InputRead
    {
        public static List<List<double>> ReadMatrixFromFile(string filePath)
        {
            List<List<double>> matrix = new List<List<double>>();

            try
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    List<double> row = new List<double>();
                    string[] elements = line.Split(' ');

                    foreach (string element in elements)
                    {
                        if (!double.TryParse(element, out double value))
                        {
                            throw new FormatException("Invalid matrix element format in the file.");
                        }
                        row.Add(value);
                    }

                    matrix.Add(row);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return null;
            }

            return matrix;
        }
    }
}
