package org.example.service;

import lombok.RequiredArgsConstructor;
import org.example.config.MatrixBeans;
import org.example.config.ReadFileBeans;
import org.example.model.Matrix;
import org.example.service.checkings.MatrixCheckings;
import org.example.service.checkings.matrixcheckings.IsColumnsEqualRows;
import org.example.service.checkings.matrixcheckings.IsSizeEquals;
import org.example.service.mathoperation.OperationsService;
import org.example.service.read.ReadFromFileService;

import java.util.ArrayList;
import java.util.List;


@RequiredArgsConstructor
public class MatrixServiceImpl implements MatrixService {

    private final ReadFromFileService<Matrix> readMatrixService = ReadFileBeans.readMatrixService();
    private final OperationsService<Matrix> matrixOperationsService;


    @Override
    public Matrix add(final String matrixPathOne,
                      final String matrixPathTwo) {
        if (!arePassedAllCheckings(matrixPathOne, matrixPathTwo, false)) {
            return MatrixBeans.emptyMatrix();
        }

        final Matrix firstMatrix = readMatrixService.read(matrixPathOne);
        final Matrix secondMatrix = readMatrixService.read(matrixPathTwo);

        return matrixOperationsService.add(firstMatrix, secondMatrix);
    }

    @Override
    public Matrix subtract(final String matrixPathOne,
                           final String matrixPathTwo) {
        if (!arePassedAllCheckings(matrixPathOne, matrixPathTwo, false)) {
            return MatrixBeans.emptyMatrix();
        }
        final Matrix firstMatrix = readMatrixService.read(matrixPathOne);
        final Matrix secondMatrix = readMatrixService.read(matrixPathTwo);

        return matrixOperationsService.subtract(firstMatrix, secondMatrix);
    }

    @Override
    public Matrix multiply(final String matrixPathOne,
                           final String matrixPathTwo) {
        if (!arePassedAllCheckings(matrixPathOne, matrixPathTwo, true)) {
            return MatrixBeans.emptyMatrix();
        }
        final Matrix firstMatrix = readMatrixService.read(matrixPathOne);
        final Matrix secondMatrix = readMatrixService.read(matrixPathTwo);

        return matrixOperationsService.multiply(firstMatrix, secondMatrix);
    }

    private boolean arePassedAllCheckings(final String matrixPathOne,
                                          final String matrixPathTwo,
                                          final boolean isMultiplying) {
        final Matrix firstMatrix = readMatrixService.read(matrixPathOne);
        final Matrix secondMatrix = readMatrixService.read(matrixPathTwo);

        return areMatricesValidForOperation(firstMatrix, secondMatrix, isMultiplying);
    }

    private boolean areMatricesValidForOperation(final Matrix firstMatrix,
                                                 final Matrix secondMatrix,
                                                 final boolean isMultiplying) {
        final List<MatrixCheckings> checkings = new ArrayList<>();

        if (isMultiplying) {
            checkings.add(new IsColumnsEqualRows());
        } else {
            checkings.add(new IsSizeEquals());
        }

        for (MatrixCheckings isValid : checkings) {
            if (!isValid.check(firstMatrix, secondMatrix)) {
                return false;
            }
        }

        return true;
    }
}
