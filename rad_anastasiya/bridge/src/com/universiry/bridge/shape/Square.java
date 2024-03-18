package com.universiry.bridge.shape;

import com.universiry.bridge.color.IColor;

public class Square extends Rectangle {
    public Square(final double side, final IColor IColor) {
        super(side, side, IColor);
    }

    @Override
    public String toString() {
        return "Square{" +
                "side: " + first +
                ", color: " + IColor.name()
                + ", perimeter: " + perimeter()
                + ", square: " + square() +
                '}';
    }
}
