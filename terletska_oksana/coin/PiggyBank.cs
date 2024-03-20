using System;

class PiggyBank
{
    private List<Coin> coins = new List<Coin>();

    public void AddCoin(Coin coin)
    {
        coins.Add(coin);
    }

    public void CountCoins()
    {
        Dictionary<Coin.CurrencyType, int> counts = new Dictionary<Coin.CurrencyType, int>();

        foreach (Coin coin in coins)
        {
            if (counts.ContainsKey(coin.Currency))
            {
                counts[coin.Currency] += coin.Amount;
            }
            else
            {
                counts[coin.Currency] = coin.Amount;
            }
        }

        Console.WriteLine("У копілці є:");

        foreach (KeyValuePair<Coin.CurrencyType, int> kvp in counts)
        {
            Console.WriteLine($"{kvp.Value} {(kvp.Key == Coin.CurrencyType.USD ? "доларів" : kvp.Key == Coin.CurrencyType.EUR ? "євро" : "гривень")}");
        }
    }
}
