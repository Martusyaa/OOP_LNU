package ctrl;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.List;
import java.util.Scanner;

public class ReadingCtrl {
    public static void readFile(List<Integer> list_elements) throws FileNotFoundException {
        String path_file = "src/files/INPUT.txt";
        File input = new File(path_file);
        Scanner read_el = new Scanner(input);
        String elements = read_el.nextLine();
        String[] splitted_elements = elements.split(",");
        for (int i = 0; i < splitted_elements.length; i++) {

            list_elements.add(Integer.valueOf(splitted_elements[i]));
        }
        read_el.close();
    }
}
