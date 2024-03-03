package org.example.service;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.List;

public class ReadFromFileImpl implements ReadFromFile<Integer> {

    @Override
    public List<Integer> readArray(String filePath) throws IOException {
        return parseStringIntoList(Files.readString(Path.of(filePath)));
    }

    private List<Integer> parseStringIntoList(String stringArray) {
        stringArray = stringArray.replaceAll(" ", "");
        final List<Integer> result = new ArrayList<>();

        int value = 0;
        for (int i = 0; i < stringArray.length(); i++) {
            if (stringArray.charAt(i) != ',') {
                value = value * 10 + stringArray.charAt(i) - 48;
            } else {
                result.add(value);
                value = 0;
            }
        }
        result.add(value);

        return result;
    }
}
