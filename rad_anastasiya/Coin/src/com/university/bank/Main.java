package com.university.bank;

import java.util.ArrayList;

import static com.university.bank.Currency.EUR;
import static com.university.bank.Currency.USD;

public class Main {
  public static void main(String[] args) {

    final Bank piggyBank = new Bank(new ArrayList<>());
    piggyBank.put(new Coin(2, USD))
        .put(new Coin(4, EUR))
        .put(new Coin(5, EUR))
        .put(new Coin(6, USD));

    piggyBank.show();
  }
}
