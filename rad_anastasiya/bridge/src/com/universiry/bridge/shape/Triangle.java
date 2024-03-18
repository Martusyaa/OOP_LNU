package com.universiry.bridge.shape;

import com.universiry.bridge.color.IColor;

public class Triangle extends Shape {
    private final double first;
    private final double second;
    private final double third;

    public Triangle(final double first, final double second, final double third, final IColor IColor) {
        super(IColor);
        this.first = first;
        this.second = second;
        this.third = third;
    }


    @Override
    public double square() {
        return Math.sqrt(perimeter() * (perimeter() - first) * (perimeter() - second) * (perimeter() - third));
    }

    @Override
    public double perimeter() {
        return first + second + third;
    }

    @Override
    public String toString() {
        return "Triangle{" +
                "first: " + first +
                ", second: " + second +
                ", third: " + third +
                ", color: " + IColor.name()
                + ", perimeter: " + perimeter()
                + ", square: " + square()
                + '}';
    }
}
