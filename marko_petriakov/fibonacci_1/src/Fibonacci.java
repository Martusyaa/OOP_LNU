import manager.OutputManager;
import manager.ReadArrayManager;


import java.io.FileNotFoundException;
import java.util.*;

public final class Fibonacci {
    private Fibonacci() {}

    public static void fibonacci_sequence(final List<Integer> sequence, final int limit) throws FileNotFoundException {
        ReadArrayManager.readArray(sequence);
        calculate(limit, 0, sequence);
    }


    private static OutputManager calculate(final int limit, int steps, final List<Integer> sequence) {
        var size = sequence.size();
        int result = sequence.get(size - 2) + sequence.get(size - 1);

        if (result > limit) {
            return new OutputManager(sequence, steps);
        }
        sequence.add(result);
        steps++;

        return calculate(limit, steps, sequence);
    }




}
