package com.universiry.bridge.shape;

import com.universiry.bridge.color.IColor;

public class Circle extends Shape {
    private final double radius;

    public Circle(final double radius, final IColor IColor) {
        super(IColor);
        this.radius = radius;
    }

    @Override
    public double square() {
        return Math.PI * Math.pow(radius, 2);
    }

    @Override
    public double perimeter() {
        return 2 * Math.PI * radius;
    }

    @Override
    public String toString() {
        return "Circle{" + "radius: " + radius
                + ", color: " + IColor.name()
                + ", perimeter: " + perimeter()
                + ", square: " + square()
                + '}';
    }
}
