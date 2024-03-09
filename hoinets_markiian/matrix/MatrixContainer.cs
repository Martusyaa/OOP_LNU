using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Matrix.Operations;


namespace Matrix
{
    public class MatrixContainer
    {
        public int CountRows { get; private set; }
        public int CountCols { get; private set; }

        private double[,] matrix;
        public MatrixContainer(int rows, int cols)
        {
            CountRows = rows;
            CountCols = cols;
            matrix = new double [CountRows, CountCols];
        }

        public MatrixContainer(double[,] arr)
        {
            CountRows = arr.GetLength(0);
            CountCols = arr.GetLength(1);
            matrix = new double[CountRows, CountCols];
            Array.Copy(arr, matrix, CountRows * CountCols);
        }

        public double this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= CountRows)
                    throw new IndexOutOfRangeException("Error: row index out of range");
                if (col < 0 || col >= CountCols)
                    throw new IndexOutOfRangeException("Error: col index out of range");

                return matrix[row, col];
            }

            set
            {
                if (row < 0 || row >= CountRows)
                    throw new IndexOutOfRangeException("Error: row index out of range");
                if (col < 0 || col >= CountCols)
                    throw new IndexOutOfRangeException("Error: col index out of range");

                matrix[row, col] = value; 
            }
        }

        public double[] this[int row]
        {
            get
            {
                double[] retRow;

                if (row < 0 || row >= CountRows)
                { 
                    throw new IndexOutOfRangeException("Error: row index out of range");
                }

                retRow = new double[CountCols];
                for (int i = 0; i < CountCols; ++i)
                {
                    retRow[i] = matrix[row, i];
                }

                return retRow;
            }
        }

        public static MatrixContainer operator + (MatrixContainer obj1, MatrixContainer obj2)
        {
            MatrixContainer resultMatrix = MatrixOperations.Add(obj1, obj2);
            return resultMatrix;
        }

        public static MatrixContainer operator - (MatrixContainer obj1, MatrixContainer obj2)
        {
            MatrixContainer resultMatrix = MatrixOperations.Subtract(obj1, obj2);
            return resultMatrix;
        }

    }
}
