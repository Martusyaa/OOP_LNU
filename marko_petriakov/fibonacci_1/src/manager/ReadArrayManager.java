package manager;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class ReadArrayManager {
    public static void readArray(List<Integer> sequence) throws FileNotFoundException {
        String path = "src/file.txt";
        File file = new File(path);
        Scanner scan = new Scanner(file);
        String s = scan.nextLine();
        String[] arr = s.split(",");
        Arrays.stream(arr).forEach(str -> {int value = Integer.parseInt(str);
            sequence.add(value);
        });
    }
}
