package manager;

import java.util.List;

public class FiboOut {

    private final int steps;
    private final List<Integer> sequence;

    public FiboOut(List<Integer> sequence,int steps){
        this.steps = steps;
        this.sequence = sequence;
    }



    public String toString(){
        return "[" + sequence + "]" + " Steps: " +steps;
    }

}
