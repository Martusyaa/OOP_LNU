package org.example.bridge.shape;

import org.example.bridge.color.Color;

public abstract class Shape {

    private final Color color;

    public Shape(Color color) {
        this.color = color;
    }

    public abstract double getSquare();

    public abstract double getPerimeter();

    public void drawShape() {
        color.draw();
    }
}
