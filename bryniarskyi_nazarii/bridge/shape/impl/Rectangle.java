package org.example.bridge.shape.impl;

import org.example.bridge.color.Color;
import org.example.bridge.shape.Shape;

public class Rectangle extends Shape {

    private final double sideA;
    private final double sideB;

    public Rectangle(Color color, double sideA, double sideB) {
        super(color);
        this.sideA = sideA;
        this.sideB = sideB;
    }


    @Override
    public double getSquare() {
        return sideA * sideB;
    }

    @Override
    public double getPerimeter() {
        return 2 * (sideA + sideB);
    }
}
