package com.university.patterns.proxy;

public class Name implements IName{
  @Override
  public String name() {
    return "Name";
  }

  @Override
  public String surname() {
    return "Surname";
  }

}
