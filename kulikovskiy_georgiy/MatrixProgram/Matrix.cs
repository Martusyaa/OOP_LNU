using System;
using System.Collections.Generic;

namespace MatrixProgram
{
    public class Matrix
    {
        public List<List<double>> MatrixList { get; set; }

        public Matrix(List<List<double>> matrix)
        {
            this.MatrixList = matrix;
        }

        public override string ToString()
        {
            string toReturn = "";
            foreach (List<double> row in this.MatrixList)
            {
                foreach (double item in row)
                {
                    toReturn += item.ToString() + " ";
                }
                toReturn += "\n";
            }
            return toReturn;
        }

        public List<int> GetSize()
        {
            int rows = MatrixList.Count;
            int columns = MatrixList[0].Count;
            List<int> listToReturn = new List<int>();
            listToReturn.Add(rows);
            listToReturn.Add(columns);
            return listToReturn;
        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            if (left.GetSize()[0] == right.GetSize()[0] && left.GetSize()[1] == right.GetSize()[1])
            {
                int sizeRows = left.GetSize()[0];
                int sizeCols = left.GetSize()[1];

                List<List<double>> resultMatrix = new List<List<double>>();

                for (int i = 0; i < sizeRows; i++)
                {
                    List<double> row = new List<double>();
                    for (int j = 0; j < sizeCols; j++)
                    {
                        double leftElement = left.MatrixList[i][j];
                        double rightElement = right.MatrixList[i][j];
                        row.Add(leftElement + rightElement);
                    }
                    resultMatrix.Add(row);
                }
                return new Matrix(resultMatrix);
            }
            else
            {
                throw new ArithmeticException("Wrong matrix size");
            }
        }

        public static Matrix operator *(Matrix left, Matrix right)
        {
            if (left.GetSize()[0] == right.GetSize()[1] && left.GetSize()[1] == right.GetSize()[0])
            {
                int sizeRowsLeft = left.GetSize()[0];
                int sizeColsLeft = left.GetSize()[1];
                int sizeRowsRight = right.GetSize()[0];
                int sizeColsRight = right.GetSize()[1];

                List<List<double>> resultMatrix = new List<List<double>>();

                for (int i = 0; i < sizeRowsLeft; i++)
                {
                    List<double> row = new List<double>();

                    for (int j = 0; j < sizeColsRight; j++)
                    {
                        double result = 0;

                        for (int k = 0; k < sizeColsLeft; k++)
                        {
                            result += left.MatrixList[i][k] * right.MatrixList[k][j];
                        }

                        row.Add(result);
                    }

                    resultMatrix.Add(row);
                }
                return new Matrix(resultMatrix);
            }
            else
            {
                throw new ArithmeticException("Wrong matrix size");
            }
        }

        public static Matrix operator -(Matrix left, Matrix right)
        {
            if (left.GetSize()[0] == right.GetSize()[0] && left.GetSize()[1] == right.GetSize()[1])
            {
                int sizeRows = left.GetSize()[0];
                int sizeCols = left.GetSize()[1];

                List<List<double>> resultMatrix = new List<List<double>>();

                for (int i = 0; i < sizeRows; i++)
                {
                    List<double> row = new List<double>();
                    for (int j = 0; j < sizeCols; j++)
                    {
                        double leftElement = left.MatrixList[i][j];
                        double rightElement = right.MatrixList[i][j];
                        row.Add(leftElement - rightElement);
                    }
                    resultMatrix.Add(row);
                }
                ;
                return new Matrix(resultMatrix);
            }
            else
            {
                throw new ArithmeticException("Wrong matrix size");
            }
        }
    }
}
