using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Operations
{
    public static class MatrixOperations
    {
        // Add two matrices
        public static MatrixContainer Add(MatrixContainer firstMatrix, MatrixContainer secondMatrix)
        {
            MatrixContainer retMatrix;

            // Checks matrices size equality 
            if ((firstMatrix.CountCols != secondMatrix.CountCols) || (firstMatrix.CountRows != secondMatrix.CountRows))
            {
                throw new SizeMatrixException("Matrices sizes are not equal");
            }

            retMatrix = new MatrixContainer(firstMatrix.CountRows, firstMatrix.CountCols);

            for (int i = 0; i < firstMatrix.CountRows; ++i)
            {
                for (int j = 0; j < firstMatrix.CountCols; ++j)
                {
                    retMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return retMatrix;
        }

        // Subtract one matrices from another 
        public static MatrixContainer Subtract(MatrixContainer firstMatrix, MatrixContainer secondMatrix)
        {
            MatrixContainer retMatrix;

            // Checks matrices size equality 
            if ((firstMatrix.CountCols != secondMatrix.CountCols) || (firstMatrix.CountRows != secondMatrix.CountRows))
            {
                throw new SizeMatrixException("Matrices sizes are not equal");
            }

            retMatrix = new MatrixContainer(firstMatrix.CountRows, firstMatrix.CountCols);

            for (int i = 0; i < firstMatrix.CountRows; ++i)
            {
                for (int j = 0; j < firstMatrix.CountCols; ++j)
                {
                    retMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return retMatrix;
        }

        // Multiply two matrices
        public static MatrixContainer Multiply(MatrixContainer firstMatrix, MatrixContainer secondMatrix)
        {
            MatrixContainer retMatrix = new MatrixContainer(firstMatrix.CountRows, secondMatrix.CountCols);

            // Checking multiply size properties MxN, KxP (N == K)
            if (firstMatrix.CountCols != secondMatrix.CountRows)
            {
                throw new SizeMatrixException("firstMatrix CountCols not equal to secondMatrix CountRows");
            }

            for (int i = 0; i < firstMatrix.CountRows; ++i)
            {
                for (int j = 0; j < secondMatrix.CountCols; ++j)
                {
                    retMatrix[i, j] = 0;
                    for (int c = 0; c < firstMatrix.CountCols; ++c)
                    {
                        retMatrix[i, j] += firstMatrix[i, c] * secondMatrix[c, j];
                    }

                }
            }

            return retMatrix;
        }

    }

    public class SizeMatrixException : Exception
    {
        public SizeMatrixException(string message) : base(message) { }
    }
}
