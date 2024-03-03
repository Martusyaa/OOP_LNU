import ctrl.OutputCtrl;
import ctrl.ReadingCtrl;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.List;
import java.util.Scanner;

public class Fibonacci {
    private Fibonacci() {
    }


    public static OutputCtrl get_fibbo_func(final int boarder, final List<Integer> list) throws FileNotFoundException {
        ReadingCtrl.readFile(list);
        return fibbo_func(boarder, list, 0);

    }
    private static OutputCtrl fibbo_func(final int boarder, final List<Integer> list, int steps) {

        int size = list.size();
        int next_element = list.get(size - 2) + list.get(size -1);
        if (next_element >= boarder) {
            return new OutputCtrl(steps, list);

        }
        list.add(next_element);
        steps++;
        return fibbo_func(boarder, list, steps);

    }
}

