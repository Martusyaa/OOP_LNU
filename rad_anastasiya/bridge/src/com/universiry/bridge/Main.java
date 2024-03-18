package com.universiry.bridge;

import com.universiry.bridge.color.Blue;
import com.universiry.bridge.color.Red;
import com.universiry.bridge.color.Violet;
import com.universiry.bridge.color.Yellow;
import com.universiry.bridge.shape.Circle;
import com.universiry.bridge.shape.Rectangle;
import com.universiry.bridge.shape.Shape;
import com.universiry.bridge.shape.Square;
import com.universiry.bridge.shape.Triangle;

public class Main {
  public static void main(String[] args) {
    final Shape circle = new Circle(3, new Yellow());
    final Shape square = new Square(4, new Blue());
    final Shape rectangle = new Rectangle(4, 5, new Red());
    final Shape triangle = new Triangle(5, 8, 8, new Violet());

    System.out.println(circle);
    System.out.println(square);
    System.out.println(rectangle);
    System.out.println(triangle);
  }
}