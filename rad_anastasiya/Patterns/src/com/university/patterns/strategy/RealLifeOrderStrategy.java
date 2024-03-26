package com.university.patterns.strategy;

public class RealLifeOrderStrategy implements OrderStrategy{
  @Override
  public void order() {
    System.out.println("I decide buy smth in real shop!");
  }
}
