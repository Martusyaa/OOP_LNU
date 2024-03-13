package org.example.service.checkings.matrixcheckings;

import org.example.model.Matrix;
import org.example.service.checkings.MatrixCheckings;

public class IsColumnsEqualRows implements MatrixCheckings {

    @Override
    public boolean check(Matrix firstMatrix, Matrix secondMatrix) {
        boolean isColumnsEqualRows = false;
        try {
            isColumnsEqualRows = firstMatrix.getMatrix()[0].length == secondMatrix.getMatrix().length;
        } catch (Exception e) {
            return false;
        }
        if (!isColumnsEqualRows) {
            System.out.println("\u001B[31m" + "Mat1 column size must be equal to Mat2 row size");
        }
        return false;
    }
}
