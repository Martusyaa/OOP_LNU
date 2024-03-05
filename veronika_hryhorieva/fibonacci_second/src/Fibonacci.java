import ctrl.OutputCtrl;
import ctrl.ReadingCtrl;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.List;
import java.util.Scanner;

public class Fibonacci {
    private Fibonacci() {
    }


    public static OutputCtrl get_fibbo_func(final List<Integer> list, int steps) throws FileNotFoundException {
        ReadingCtrl.readFile(list);
        return fibbo_func(list, steps);
    }

    private static OutputCtrl fibbo_func(final List<Integer> list, int steps) {

        int first_element = list.get(list.size() - 2);
        int second_element = list.get(list.size() - 1);
        int next_element = first_element + second_element;
        list.add(next_element);
        steps -= 1;
        if (steps <= 0) {
            return new OutputCtrl(steps, list);

        }
        return fibbo_func(list, steps);

    }

}

