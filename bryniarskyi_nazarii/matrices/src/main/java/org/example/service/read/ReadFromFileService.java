package org.example.service.read;

import java.io.IOException;


public interface ReadFromFileService<T> {

    T read(final String filePath);
}
