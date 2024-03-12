package org.example.service.checkings.matrixcheckings;

import org.example.model.Matrix;
import org.example.service.checkings.MatrixCheckings;

public class IsSizeEquals implements MatrixCheckings {

    @Override
    public boolean check(final Matrix firstMatrix,
                         final Matrix secondMatrix) {
        boolean isSizeEquals = false;
        try {
            isSizeEquals = firstMatrix.getMatrix().length == secondMatrix.getMatrix().length;
        } catch (Exception e) {
            return false;
        }

        if (!isSizeEquals) {
            System.out.println("\u001B[31m" + "Matrix sizes must be equal.");
        }

        return isSizeEquals;
    }
}
