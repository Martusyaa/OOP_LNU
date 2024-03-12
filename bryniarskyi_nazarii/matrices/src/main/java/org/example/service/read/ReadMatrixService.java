package org.example.service.read;

import lombok.RequiredArgsConstructor;
import org.example.config.MatrixBeans;
import org.example.model.Matrix;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;


public class ReadMatrixService implements ReadFromFileService<Matrix> {


    @Override
    public Matrix read(final String matrixPath) {
        final List<List<Integer>> matrix = new ArrayList<>();

        try (BufferedReader br = new BufferedReader(new FileReader(matrixPath))) {
            String line;

            while ((line = br.readLine()) != null) {
                final List<Integer> row = new ArrayList<>();
                final String[] values = line.trim().split("\\s+");

                for (String value : values) {
                    row.add(Integer.parseInt(value));
                }

                matrix.add(row);
            }

        } catch (IOException e) {
            e.printStackTrace();
        }

        try {
            return convertListToMatrix(matrix);
        } catch (Exception e) {
            System.out.println("\u001B[31m" + "Invalid matrix passed.");
            return MatrixBeans.emptyMatrix();
        }
    }


    private Matrix convertListToMatrix(List<List<Integer>> matrixList) {
        final int rows = matrixList.size();
        try {
            matrixList.get(0);
        } catch (Exception e) {
            System.out.println("fkdjnnjfdn");
        }
        final int cols = matrixList.get(0).size();

        final int[][] matrix = new int[rows][cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                matrix[i][j] = matrixList.get(i).get(j);
            }
        }

        return new Matrix(matrix);
    }
}
