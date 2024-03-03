package org.example.model;

import java.util.List;

public class FibonacciPair {

    private final int steps;
    private final List<Integer> result;

    public FibonacciPair(int steps, List<Integer> result) {
        this.steps = steps;
        this.result = result;
    }

    @Override
    public String toString() {
        return "FibonacciPair{" +
                "steps=" + steps +
                ", result=" + result +
                '}';
    }
}
