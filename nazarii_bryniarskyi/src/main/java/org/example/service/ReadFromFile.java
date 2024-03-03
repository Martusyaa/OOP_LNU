package org.example.service;

import java.io.IOException;
import java.util.List;

public interface ReadFromFile<T> {

    List<T> readArray(final String filePath) throws IOException;
}
