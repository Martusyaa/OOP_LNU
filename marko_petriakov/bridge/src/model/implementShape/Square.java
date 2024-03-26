package model.implementShape;

import model.Color;

public class Square extends Rectangle {
    private float side;
    public Square(float side, Color color){
        super(side,side,color);
        this.side = side;
    }

}
