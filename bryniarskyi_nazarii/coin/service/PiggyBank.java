package service;

import model.Coin;
import util.Currency;

import java.util.HashMap;
import java.util.Map;

public class PiggyBank implements Bank<Coin> {

    private final Map<Currency, Integer> coins;

    public PiggyBank() {
        coins = new HashMap<>();
        initCoins();
    }

    private void initCoins() {
        coins.put(Currency.UAH, 0);
        coins.put(Currency.DOLLAR, 0);
        coins.put(Currency.EURO, 0);
    }

    @Override
    public void printMoneyList() {
        for (var entry : coins.entrySet()) {
            System.out.println(entry.getKey() + ": " + entry.getValue());
        }
    }

    @Override
    public Coin put(Coin coin) {
        switch (coin.getCurrency()) {
            case UAH -> coins.put(Currency.UAH, coins.get(Currency.UAH) + coin.getDenomination());
            case DOLLAR -> coins.put(Currency.DOLLAR, coins.get(Currency.DOLLAR) + coin.getDenomination());
            case EURO -> coins.put(Currency.EURO, coins.get(Currency.EURO) + coin.getDenomination());
        }
        return coin;
    }
}
