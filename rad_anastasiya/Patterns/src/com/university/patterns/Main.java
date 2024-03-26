package com.university.patterns;

import com.university.patterns.proxy.IName;
import com.university.patterns.proxy.Name;
import com.university.patterns.proxy.NameProxy;
import com.university.patterns.singleton.Singleton;
import com.university.patterns.strategy.OnlineOrderStrategy;
import com.university.patterns.strategy.OrderStrategy;
import com.university.patterns.strategy.RealLifeOrderStrategy;
import com.university.patterns.strategy.User;

public class Main {
  public static void main(String[] args) {

    System.out.println("Singleton");
    System.out.println(Singleton.provide());
    System.out.println(Singleton.provide());
    System.out.println();

    System.out.println("Proxy");
    final IName name = new Name();
    final IName proxy = new NameProxy(name);

    System.out.println(name);
    System.out.println(name.name());
    System.out.println(name.surname());
    System.out.println();

    System.out.println(proxy);
    System.out.println(proxy.name());
    System.out.println(proxy.surname());
    System.out.println();

    System.out.println("Strategy");
    OrderStrategy online = new OnlineOrderStrategy();
    OrderStrategy offline = new RealLifeOrderStrategy();
    User user = new User(online);
    user.order();
    user.setStrategy(offline);
    user.order();
    System.out.println();
  }
}