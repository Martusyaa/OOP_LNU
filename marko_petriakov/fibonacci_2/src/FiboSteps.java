import manager.FiboOut;
import manager.FiboRead;

import java.io.FileNotFoundException;
import java.util.List;

public final class FiboSteps {

    private FiboSteps() {
    }


    public static FiboOut fiboSequence(int steps, final List<Integer> sequence) throws FileNotFoundException {
        FiboRead.readArray(sequence);
        return calculate(steps, sequence);

    }

    private static FiboOut calculate(int steps, final List<Integer> sequence) {
        if (steps <= 0) {
            return new FiboOut(sequence, sequence.size() - 2);
        } else {
            steps--;
            var a = sequence.size();
            //change
            int prelast = sequence.size() - 2;
            int last = sequence.size() - 1;
            int result = sequence.get(last) + sequence.get(prelast);
            sequence.add(result);
            return calculate(steps, sequence);
        }
    }


}
