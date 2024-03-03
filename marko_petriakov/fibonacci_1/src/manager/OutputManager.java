package manager;

import java.util.List;

public class OutputManager {


    private final int steps;
    private final List<Integer> sequence;

    public OutputManager(List<Integer> sequence,int steps){
        this.steps = steps;
        this.sequence = sequence;
    }



    public String toString(){
            return "[" + sequence + "]" + "\n Steps: " +steps;
    }
}
