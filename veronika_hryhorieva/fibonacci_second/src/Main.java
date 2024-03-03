import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;


public class Main {

    public static void main(String[] args) throws FileNotFoundException {
        List<Integer> fibbo_elements = new ArrayList<>();
        Fibonacci.get_fibbo_func(fibbo_elements, 6);
        System.out.println(Fibonacci.get_fibbo_func(fibbo_elements, 6));

    }

}
