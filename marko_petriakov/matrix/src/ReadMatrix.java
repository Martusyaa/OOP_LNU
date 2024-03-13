import java.io.File;

import java.io.IOException;
import java.util.*;



public class ReadMatrix {
    public static ArrayList<ArrayList<Integer>> read(String path) throws IOException {

        File file = new File(path);
        Scanner scan = new Scanner(file);

        ArrayList<ArrayList<Integer>> temp = new ArrayList<>();

        while (scan.hasNextLine()){
            ArrayList<Integer> tempLine = new ArrayList<>();
            String next_line = scan.nextLine();
            if (next_line==""){

                break;
            }
            String[] s = next_line.split(",");
            for (int i = 0; i < s.length; i++) {
                 tempLine.add(Integer.parseInt(s[i]));
            }

            temp.add(tempLine);

        }

        return temp;


    }

}
