package org.example;

import org.example.model.FibonacciPair;
import org.example.service.Fibonacci;
import org.example.service.ReadFromFile;
import org.example.service.ReadFromFileImpl;

import java.io.IOException;
import java.util.List;

public class Main {
    private final static ReadFromFile<Integer> readFromFile = new ReadFromFileImpl();

    public static void main(String[] args) throws IOException {
        final List<Integer> initArray = readFromFile.readArray(
                "src/main/java/org/example/data/data.txt");

        final FibonacciPair borderFibonacci = Fibonacci.border(100, initArray);
        final List<Integer> stepsFibonacci = Fibonacci.steps(10, initArray);

        System.out.println(borderFibonacci);
        System.out.println("FibonacciSteps " + stepsFibonacci);
    }
}