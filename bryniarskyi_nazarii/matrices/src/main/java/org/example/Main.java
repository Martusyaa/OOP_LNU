package org.example;

import org.example.config.MatrixBeans;
import org.example.config.ReadFileBeans;
import org.example.model.Matrix;
import org.example.service.MatrixService;
import org.example.service.read.ReadFromFileService;
import org.example.utils.MatrixPath;


public class Main {
    public static void main(String[] args) {
        MatrixService matrixServiceImpl = MatrixBeans.matrixServiceImpl();

        System.out.println(matrixServiceImpl.add(MatrixPath.FIRST_MATRIX, MatrixPath.SECOND_MATRIX));
        System.out.println(matrixServiceImpl.subtract(MatrixPath.FIRST_MATRIX, MatrixPath.SECOND_MATRIX));
        System.out.println(matrixServiceImpl.multiply(MatrixPath.FIRST_MATRIX, MatrixPath.SECOND_MATRIX));
    }
}