package org.example.bridge.shape.impl;

import org.example.bridge.color.Color;
import org.example.bridge.shape.Shape;

public class Square extends Rectangle {

    private final double side;

    public Square(Color color, double side) {
        super(color, side, side);
        this.side = side;
    }
}
