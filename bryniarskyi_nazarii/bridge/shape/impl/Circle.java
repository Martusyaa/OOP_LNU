package org.example.bridge.shape.impl;

import org.example.bridge.color.Color;
import org.example.bridge.shape.Shape;

public class Circle extends Shape {

    private final double radius;

    public Circle(Color color,
                  double radius) {
        super(color);
        this.radius = radius;
    }

    @Override
    public double getSquare() {
        return Math.PI * radius * radius;
    }

    @Override
    public double getPerimeter() {
        return 2 * Math.PI * radius;
    }
}
