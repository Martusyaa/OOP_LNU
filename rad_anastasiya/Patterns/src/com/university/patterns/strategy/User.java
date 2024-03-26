package com.university.patterns.strategy;

public class User {
  private OrderStrategy strategy;

  public User(OrderStrategy strategy) {
    this.strategy = strategy;
  }

  public void setStrategy(OrderStrategy strategy) {
    this.strategy = strategy;
  }

  public void order() {
    strategy.order();
  }
}
