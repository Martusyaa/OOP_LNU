package org.example.bridge.color.impl;

import org.example.bridge.color.Color;

public class Red implements Color {

    @Override
    public void draw() {
        System.out.println("Red draw");
    }
}
