package org.example.bridge.shape.impl;

import org.example.bridge.color.Color;
import org.example.bridge.shape.Shape;

public class Triangle extends Shape {

    private final double sideA;
    private final double sideB;
    private final double sideC;

    public Triangle(Color color, double sideA, double sideB, double sideC) {
        super(color);
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    @Override
    public double getSquare() {
        final double p = getPerimeter()/2;
        return Math.sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    @Override
    public double getPerimeter() {
        return sideA + sideB + sideC;
    }
}
