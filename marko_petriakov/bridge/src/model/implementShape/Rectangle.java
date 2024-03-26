package model.implementShape;

import model.Color;
import model.Shape;

public class Rectangle implements Shape {

    private float a_side;
    private float b_side;
    private Color color;

    public Rectangle(float a_side, float b_side, Color color){this.a_side=a_side; this.b_side=b_side; this.color=color;}

    @Override
    public float square() {
        return a_side*b_side;
    }

    @Override
    public float perimeter() {
        return 2*(b_side+a_side);
    }

    @Override
    public Color showColor() {
        return color;
    }


    public float getA_side() {
        return a_side;
    }

    public void setA_side(float a_side) {
        this.a_side = a_side;
    }

    public float getB_side() {
        return b_side;
    }

    public void setB_side(float b_side) {
        this.b_side = b_side;
    }
}
