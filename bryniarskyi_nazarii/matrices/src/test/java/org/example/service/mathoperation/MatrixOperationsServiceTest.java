package org.example.service.mathoperation;

import org.example.config.MatrixBeans;
import org.example.model.Matrix;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class MatrixOperationsServiceTest {
    private final OperationsService<Matrix> matrixOperationsService = MatrixBeans.matrixOperationsService();

    @Test
    void add() {
        final Matrix mat1 = new Matrix(new int[][]{
                {1, 2, 3},
                {2, 3, 4},
                {3, 4, 5}
        });

        final Matrix mat2 = new Matrix(new int[][]{
                {9, 1, 8},
                {1, 4, 5},
                {1, 1, 1}
        });

        final Matrix res = new Matrix(new int[][] {
                {10, 3, 11},
                {3, 7, 9},
                {4, 5, 6}
        });

        assertEquals(matrixOperationsService.add(mat1, mat2), res);
    }

    @Test
    void subtract() {
        final Matrix mat1 = new Matrix(new int[][]{
                {1, 2, 3},
                {2, 3, 4},
                {3, 4, 5}
        });

        final Matrix mat2 = new Matrix(new int[][]{
                {9, 1, 8},
                {1, 4, 5},
                {1, 1, 1}
        });

        final Matrix res = new Matrix(new int[][] {
                {-8, 1, -5},
                {1, -1, -1},
                {2, 3, 4}
        });

        assertEquals(matrixOperationsService.subtract(mat1, mat2), res);
    }

    @Test
    void multiply() {
        final Matrix mat1 = new Matrix(new int[][]{
                {1, 2, 3},
                {2, 3, 4},
                {3, 4, 5}
        });

        final Matrix mat2 = new Matrix(new int[][]{
                {9, 1, 8},
                {1, 4, 5},
                {1, 1, 1}
        });

        final Matrix res = new Matrix(new int[][] {
                {14, 12, 21},
                {25, 18, 35},
                {36, 24, 49}
        });

        assertEquals(matrixOperationsService.multiply(mat1, mat2), res);
    }
}