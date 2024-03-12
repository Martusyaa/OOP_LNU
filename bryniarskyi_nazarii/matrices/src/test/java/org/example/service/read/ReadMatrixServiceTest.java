package org.example.service.read;

import org.example.config.ReadFileBeans;
import org.example.model.Matrix;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class ReadMatrixServiceTest {

    private final ReadFromFileService<Matrix> readMatrixService = ReadFileBeans.readMatrixService();


    @Test
    void read() {
        final Matrix realMatrix = new Matrix(new int[][]{
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
        });
        final Matrix matrixFromFile =
                readMatrixService.read("src/test/java/org/example/service/data/valid-matrix.txt");
        assertEquals(realMatrix, matrixFromFile);
    }

    @Test
    void invalidMatrix() {
        boolean isThrown = false;
        try {
            readMatrixService.read("src/test/java/org/example/service/data/invalid-matrix.txt");
        } catch (Exception e) {
            isThrown = true;
        }
        assertTrue(isThrown);
    }
}