class Program
{
    static void Main(string[] args)
    {
        MoneyBox myMoneyBox = new MoneyBox();

        Coin coin1 = new Coin(1, Level.Dolar);
        Coin coin2 = new Coin(5, Level.Euro);
        Coin coin3 = new Coin(3, Level.Gryvnya);
        Coin coin4 = new Coin(2, Level.Euro);
        myMoneyBox.AddCoin(coin1);
        myMoneyBox.AddCoin(coin2);
        myMoneyBox.AddCoin(coin3);
        myMoneyBox.AddCoin(coin4);
        
        int totalCoins = myMoneyBox.CountCoins();
        Console.WriteLine("Total coins in the money box: " + totalCoins);
        myMoneyBox.PrintMoney();
    }
}