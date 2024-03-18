package com.universiry.bridge.shape;

import com.universiry.bridge.color.IColor;

public class Rectangle extends Shape {
    protected final double first;
    protected final double second;

    public Rectangle(final double first, final double second, final IColor IColor) {
        super(IColor);
        this.first = first;
        this.second = second;
    }

    @Override
    public double square() {
        return first * second;
    }

    @Override
    public double perimeter() {
        return 2 * (first + second);
    }

    @Override
    public String toString() {
        return "Rectangle{" +
                "first: " + first +
                ", second: " + second +
                ", color: " + IColor.name()
                + ", perimeter: " + perimeter()
                + ", square: " + square()
                + '}';
    }
}
