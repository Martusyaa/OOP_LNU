package org.example.service;


import org.example.model.FibonacciPair;

import java.util.ArrayList;
import java.util.List;


public class Fibonacci {

    private Fibonacci() {}


    public static FibonacciPair border(final int border,
                                       final List<Integer> values) {
        return trueBorder(border, getStartArray(values), 0);
    }

    public static List<Integer> steps(int steps,
                                      final List<Integer> values) {
        return trueSteps(steps, getStartArray(values));
    }

    private static FibonacciPair trueBorder(final int border,
                                            final List<Integer> values,
                                            int counter) {
        final int valuesSize = values.size();
        final int temp = values.get(valuesSize-1) + values.get(valuesSize-2);

        if (temp > border)
            return new FibonacciPair(counter, values);

        values.add(temp);
        counter++;

        return trueBorder(border, values, counter);
    }

    private static List<Integer> trueSteps(int steps,
                                           final List<Integer> values) {
        steps--;
        final int valuesSize = values.size();
        final int temp = values.get(valuesSize-1) + values.get(valuesSize-2);
        values.add(temp);

        return steps == 0
                ? values
                : trueSteps(steps, values);
    }

    private static List<Integer> getStartArray(final List<Integer> values) {
        final int valuesSize = values.size();
        return new ArrayList<>(
                List.of(values.get(valuesSize-1), values.get(valuesSize-2)));
    }

}
