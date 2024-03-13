package org.example.service.mathoperation;

import org.example.model.Matrix;

public class MatrixOperationsService implements OperationsService<Matrix> {

    @Override
    public Matrix add(final Matrix firstMatrix,
                      final Matrix secondMatrix) {
        final int[][] matOne = firstMatrix.getMatrix();
        final int[][] matTwo = secondMatrix.getMatrix();
        final int rows = matOne.length;
        final int cols = matOne[0].length;
        final int[][] result = new int[rows][cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i][j] = matOne[i][j] + matTwo[i][j];
            }
        }

        return new Matrix(result);
    }

    @Override
    public Matrix subtract(final Matrix firstMatrix,
                           final Matrix secondMatrix) {
        final int[][] matOne = firstMatrix.getMatrix();
        final int[][] matTwo = secondMatrix.getMatrix();
        final int rows = matOne.length;
        final int cols = matOne[0].length;
        final int[][] result = new int[rows][cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i][j] = matOne[i][j] - matTwo[i][j];
            }
        }

        return new Matrix(result);
    }

    @Override
    public Matrix multiply(final Matrix firstMatrix,
                           final Matrix secondMatrix) {
        final int[][] matOne = firstMatrix.getMatrix();
        final int[][] matTwo = secondMatrix.getMatrix();
        final int rows = matOne.length;
        final int cols = matTwo[0].length;
        final int[][] result = new int[rows][cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                for (int k = 0; k < matOne[0].length; k++) {
                    result[i][j] += matOne[i][k] * matTwo[k][j];
                }
            }
        }

        return new Matrix(result);
    }
}
