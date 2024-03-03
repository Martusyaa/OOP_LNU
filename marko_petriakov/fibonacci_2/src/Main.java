import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        List<Integer> some_numbers = new ArrayList<>();
        System.out.println(FiboSteps.fiboSequence(15, some_numbers));

    }
}
