package ctrl;

import java.util.List;

public class OutputCtrl {
    private final int steps;
    private final List<Integer> list;

    public OutputCtrl(int steps, List<Integer> list)
    {
        this.steps=steps;
        this.list=list;
    }

    @Override
    public String toString() {
        return "Ряд: "+list+"\n"+"Кроків: "+steps;
    }
}
