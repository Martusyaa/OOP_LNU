using System;

class Coin
{
    public int Amount { get; set; }
    public CurrencyType Currency { get; set; }

    public enum CurrencyType
    {
        USD,
        EUR,
        UAH
    }

    public Coin(int amount, CurrencyType currency)
    {
        Amount = amount;
        Currency = currency;
    }
}
