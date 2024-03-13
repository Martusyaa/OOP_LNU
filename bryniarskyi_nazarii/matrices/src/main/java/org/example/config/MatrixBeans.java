package org.example.config;

import org.example.model.Matrix;
import org.example.service.MatrixService;
import org.example.service.MatrixServiceImpl;
import org.example.service.mathoperation.MatrixOperationsService;
import org.example.service.mathoperation.OperationsService;

public final class MatrixBeans {

    private static OperationsService<Matrix> matrixOperationsService = null;
    private static MatrixService matrixServiceImpl = null;
    private static Matrix emptyMatrix = null;

    private MatrixBeans() {}


    public static MatrixService matrixServiceImpl() {
        return matrixServiceImpl == null
                ? matrixServiceImpl = new MatrixServiceImpl(matrixOperationsService())
                : matrixServiceImpl;
    }

    public static OperationsService<Matrix> matrixOperationsService() {
        return matrixOperationsService == null
                ? matrixOperationsService= new MatrixOperationsService()
                : matrixOperationsService;
    }

    public static Matrix emptyMatrix() {
        return emptyMatrix == null
                ? emptyMatrix = new Matrix()
                : emptyMatrix;
    }
}
