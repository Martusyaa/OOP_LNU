package com.universiry.bridge.shape;

import com.universiry.bridge.color.IColor;

public abstract class Shape implements IShapeMath {
  protected IColor IColor;

  public Shape(final IColor IColor) {
    this.IColor = IColor;
  }
}
