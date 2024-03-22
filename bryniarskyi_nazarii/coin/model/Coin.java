package model;

import util.Currency;

public class Coin {
    private final int denomination;
    private final Currency currency;

    public Coin(int denomination, Currency currency) {
        this.denomination = denomination;
        this.currency = currency;
    }

    public int getDenomination() {
        return denomination;
    }

    public Currency getCurrency() {
        return currency;
    }
}
