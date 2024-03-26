package model.implementShape;

import model.Color;
import model.Shape;

public class Circle implements Shape {

    private float radius;

    private Color color;

    public Circle(float radius, Color color){this.radius = radius; this.color=color;}
    @Override
    public float square() {
        return Math.round(Math.PI*Math.pow(radius,2));
    }

    @Override
    public float perimeter() {
        return Math.round(2*Math.PI*radius);
    }

    @Override
    public Color showColor() {
        return color;
    }

    public float getRadius() {
        return radius;
    }

    public void setRadius(float radius) {
        this.radius = radius;
    }
}
