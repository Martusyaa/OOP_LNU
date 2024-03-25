using System;

class Program
{
    static void Main(string[] args)
    {
        PiggyBank piggyBank = new PiggyBank();

        piggyBank.AddCoin(new Coin(2, Coin.CurrencyType.USD));
        piggyBank.AddCoin(new Coin(1, Coin.CurrencyType.EUR)); 
        piggyBank.AddCoin(new Coin(3, Coin.CurrencyType.USD)); 
        piggyBank.AddCoin(new Coin(10, Coin.CurrencyType.UAH));
        piggyBank.AddCoin(new Coin(5, Coin.CurrencyType.UAH)); 

        piggyBank.CountCoins();
    }
}
