package org.example.config;

import org.example.model.Matrix;
import org.example.service.read.ReadFromFileService;
import org.example.service.read.ReadMatrixService;

public final class ReadFileBeans {

    private static ReadFromFileService<Matrix> readMatrixService = null;

    private ReadFileBeans() {}


    public static ReadFromFileService<Matrix> readMatrixService() {
        return readMatrixService == null
                ? readMatrixService = new ReadMatrixService()
                : readMatrixService;
    }
}
