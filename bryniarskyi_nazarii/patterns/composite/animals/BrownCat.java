package org.example.composite.animals;

public class BrownCat extends Cat {

    @Override
    public void voice() {
        System.out.print("Brown ");
        super.voice();
    }
}
