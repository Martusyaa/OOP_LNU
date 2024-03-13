package org.example.service;

import org.example.model.Matrix;

public interface MatrixService {

    Matrix add(final String matrixPathOne,
               final String matrixPathTwo);

    Matrix subtract(final String matrixPathOne,
                    final String matrixPathTwo);

    Matrix multiply(final String matrixPathOne,
                    final String matrixPathTwo);

}
