package com.university.patterns.proxy;

public class NameProxy implements IName {
  private final IName name;

  public NameProxy(IName name) {
    this.name = name;
  }

  @Override
  public String name() {
    return "Proxy" + name.name();
  }

  @Override
  public String surname() {
    return "Proxy" + name.surname();
  }
}
