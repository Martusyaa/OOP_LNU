public class MoneyBox
{
    List<Coin> MyMoney = new List<Coin>();
    public void AddCoin(Coin coin)
    {
        MyMoney.Add(coin);
    }
    // public void RemoveCoin(Coin coin)
    // {
    //     MyMoney.Remove(coin);
    // }
    public int CountCoins()
    {
        int totalCoins = 0;
        foreach (Coin coin in MyMoney)
        {
            totalCoins += coin.GetCoins();
        }
        return totalCoins;
    }
    public void PrintMoney()
    {
        Console.WriteLine("Coins in the money box:");
        foreach (var group in MyMoney.GroupBy(coin => coin.GetSymbol()))
        {
            int totalCoins = group.Sum(coin => coin.GetCoins());
            Console.WriteLine($"{totalCoins} {group.Key}");
        }

    }
    
}