package com.university.patterns.strategy;

public class OnlineOrderStrategy implements OrderStrategy{
  @Override
  public void order() {
    System.out.println("I decide buy smth in online shop!");
  }
}
