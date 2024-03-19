package com.university.bank;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class Bank {
  private final List<Coin> coins;

  public Bank(final List<Coin> coins) {
    this.coins = new ArrayList<>(coins);
  }


  public void show() {
    //погрупували
    final Map<Currency, List<Coin>> grouped = coins.stream().collect(Collectors.groupingBy(Coin::getCurrency));
    //вивели
    System.out.println(grouped.entrySet().stream().map(this::mapToString).reduce(String::concat).orElse(""));
  }

  public Bank put(final Coin coin) {
    this.coins.add(coin);
    return this;
  }

  private String mapToString(Map.Entry<Currency, List<Coin>> entry) {
    final Integer sum = entry.getValue()
        .stream()
        .map(Coin::getDenomination)
        .reduce(Integer::sum)
        .orElse(0);
    return String.format("%s %s in piggy bank\n", sum, entry.getKey());
  }
}
