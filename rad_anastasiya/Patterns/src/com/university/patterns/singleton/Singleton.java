package com.university.patterns.singleton;

import java.util.Objects;

public final class Singleton {
  private static Singleton instance;
//  private static Singleton res;

  private Singleton() {
  }

  public static Singleton provide() {
    if (Objects.isNull(instance)) {
      instance = new Singleton();
    }
    return instance;
//    res = new Singleton();
//    return  res;
  }
}
