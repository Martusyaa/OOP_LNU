package model.implementShape;

import model.Color;
import model.Shape;

public class Triangle implements Shape {

    private final float sideA;
    private final float sideB;
    private final float sideC;
    private final Color color;

    private Triangle(float sideA, float sideB, float sideC, Color color){
        this.sideA =sideA; this.sideB =sideB; this.sideC =sideC; this.color = color;
    }
    @Override
    public float square() {
        float halfSum = (sideA+sideB+sideC)/2;
        return (float) Math.sqrt(halfSum*(halfSum-sideA)*(halfSum-sideB)*(halfSum-sideC));
    }

    @Override
    public float perimeter() {
        return sideA+sideB+sideC;
    }

    @Override
    public Color showColor() {
        return color;
    }
}
